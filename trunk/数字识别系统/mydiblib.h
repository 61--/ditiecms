#include "dibapi.h"
#include <iostream>
#include <deque>
#include <math.h>
using namespace std;

typedef deque<CRect> CRectLink;
typedef deque<HDIB>  HDIBLink;

//����һЩ��Ҫ��ȫ�ֱ���
int w_sample=8;
int h_sample=16;
bool fileloaded;
bool gyhinfoinput;
bool gyhfinished;
int digicount;
int m_lianXuShu;
CRectLink m_charRectCopy;
CRectLink m_charRect;
HDIBLink  m_dibRect;
HDIBLink  m_dibRectCopy;
HDIB m_hDIB;
CString strPathName;
CString strPathNameSave;

/********************************function declaration*************************************/

//�����Ļ
void ClearAll(CDC* pDC);
//����Ļ����ʾλͼ
void DisplayDIB(CDC* pDC,HDIB hDIB);
//�Էָ���λͼ���гߴ��׼��һ��
void StdDIBbyRect(HDIB hDIB, int tarWidth, int tarHeight);
//����б�ʵ���
void SlopeAdjust(HDIB hDIB);
//ȥ����ɢ������
void RemoveScatterNoise(HDIB hDIB);
//�ݶ���
void GradientSharp(HDIB hDIB);
//����
void DrawFrame(CDC* pDC,HDIB hDIB, CRectLink charRect,unsigned int linewidth,COLORREF color);
//���Ҷ�ͼ��ֵ��
void ConvertGrayToWhiteBlack(HDIB hDIB);
//��256ɫλͼתΪ�Ҷ�ͼ
void Convert256toGray(HDIB hDIB);
//ϸ��
void Thinning(HDIB hDIB);
//��λͼ���зָ�.����һ���洢��ÿ��ָ����������
CRectLink CharSegment(HANDLE hDIB);
//���������ŵ���
HDIB AutoAlign(HDIB hDIB);
//�ж��Ƿ�����ɢ������
bool DeleteScaterJudge(LPSTR lpDIBBits,WORD lLineBytes, LPBYTE lplab, int lWidth, int lHeight, int x, int y, CPoint lab[], int lianXuShu);
//��ͼ�����ģ�����
HDIB Template(HDIB hDIB,double * tem ,int tem_w,int tem_h,double xishu);
//��ͼ�������ֵ�˲�
HDIB MidFilter(HDIB hDIB,int tem_w,int tem_h);
//��ͼ�����ֱ��ͼ����
void Equalize(HDIB hDIB);
/***********************************implementation*************************************/

/*********************************** ************************************
�������ƣ�DisplayDIB
������
	CDC* pDC			-ָ��ǰ�豸�����ģ�Divice Context����ָ��
	HDIB hDIB			-Ҫ��ʾ��λͼ�ľ��
**********************************************************************/

void DisplayDIB(CDC* pDC,HDIB hDIB)
{
	BYTE* lpDIB=(BYTE*)::GlobalLock((HGLOBAL)hDIB);
	// ��ȡDIB��Ⱥ͸߶�
	int cxDIB =  ::DIBWidth((char*) lpDIB);
	int cyDIB =  ::DIBHeight((char*)lpDIB);
	CRect rcDIB,rcDest;
	rcDIB.top = rcDIB.left = 0;
	rcDIB.right = cxDIB;
	rcDIB.bottom = cyDIB;
	//����Ŀ��ͻ��������С�ߴ�
	rcDest = rcDIB;
	//CDC* pDC=GetDC();
	ClearAll(pDC);
	//�ڿͻ�����ʾͼ��
	//for(int ii=0;ii<10;ii++)
		::PaintDIB(pDC->m_hDC,rcDest,hDIB,rcDIB,NULL);
	::GlobalUnlock((HGLOBAL)hDIB);
}

void ClearAll(CDC *pDC)
{
	CRect rect;
	//GetClientRect(&rect);
	rect.left =0;rect.top =0;rect.right =2000;rect.bottom =1000;
	CPen pen;
	pen.CreatePen (PS_SOLID,1,RGB(255,255,255));
	pDC->SelectObject (&pen);
	pDC->Rectangle (&rect);
	::DeleteObject (pen);
}
/*******************************************
*
*  �������ƣ�
*  AutoAlign()
*
*  ������
*    HDIB   hDIB        ��ԭͼ��ľ��
*
*  ����ֵ   
*    HDIB               ���������к����ͼ��ľ��
*
*  ���ܣ�
*     �������˱�׼��������ַ����й��������У��Է�����һ���Ĵ���
*
*  ˵����
*     �������еĲ��������ڱ�׼������֮�����
*
********************************************************/


HDIB AutoAlign(HDIB hDIB)
{   
	
	//ָ��ͼ���ָ��
 	BYTE* lpDIB=(BYTE*)::GlobalLock ((HGLOBAL)hDIB);

	//ָ��������ʼλ�õ�ָ��
	BYTE* lpDIBBits=(BYTE*)::FindDIBBits ((char*)lpDIB);

	//ָ�����ص�ָ��
	BYTE* lpSrc;

	//��ȡͼ��Ŀ��
	LONG lWidth=::DIBWidth ((char*)lpDIB);

	//��ȡͼ��ĸ߶�
	LONG lHeight=::DIBHeight ((char*)lpDIB);

	//��ȡ��׼���Ŀ��
	int w=m_charRect.front ().Width() ;

	//��ȡ��׼���ĸ߶�
	int h=m_charRect.front ().Height() ;

	//����һ���µ�ͼ�������ܹ�����׼�����ַ����ŷ���
	HDIB hNewDIB=::NewDIB (digicount*w,h,8);

	//ָ���µ�ͼ���ָ��
	BYTE* lpNewDIB=(BYTE*) ::GlobalLock((HGLOBAL)hNewDIB);
	
	//ָ��������ʼλ�õ�ָ��
	BYTE* lpNewDIBBits=(BYTE*)::FindDIBBits((char*)lpNewDIB);

	//ָ�����ص�ָ��
	BYTE* lpDst=lpNewDIBBits;

	//����ԭͼ��ÿ�е��ֽ���
	LONG lLineBytes=(lWidth+3)/4*4;

	//������ͼ��ÿ�е��ֽ���
	LONG lLineBytesnew =(digicount*w+3)/4*4;

	//���µ�ͼ���ʼ��Ϊ��ɫ
	memset(lpDst,(BYTE)255,lLineBytesnew * h);

	//ӳ��������������
	int i_src,j_src;

	//ѭ������
	int i,j;

	//ͳ���ַ������ı���
	int counts=0;

	//���λ����Ϣ�Ľṹ��
	CRect rect,rectnew;

	//���һ���µ�����������µ��ַ�λ����Ϣ
	m_charRectCopy.clear ();

	//��ͷ��β���ɨ��ԭ����ĸ������
	while(!m_charRect.empty() )
	{   
		//�ӱ�ͷ�ϵõ�һ�����ο�
		rect=m_charRect.front ();

		//��������ο��������ɾ��
		m_charRect.pop_front ();

		//�����µľ��ο��λ����Ϣ

		//��߽�
		rectnew.left =counts*w;

		//�ұ߽�
		rectnew.right =(counts+1)*w;

		//�ϱ߽�
		rectnew.top =0;

		//�±߽�
		rectnew.bottom =h;

		//����õ��µľ��ο���뵽�µ�������
		m_charRectCopy.push_back (rectnew);

		//��ԭ���ο��ڵ�����ӳ�䵽�µľ��ο���
		for(i=0;i<h;i++)
		{  
			for(j=counts*w;j<(counts+1)*w;j++)
			{   

				//����ӳ������
	          	i_src=rect.top +i;
				j_src=rect.left +j-counts*w;

				//�������ص�ӳ��
				lpSrc=(BYTE *)lpDIBBits + lLineBytes *  i_src + j_src;
				lpDst=(BYTE *)lpNewDIBBits + lLineBytesnew * i + j;
				*lpDst=*lpSrc;
			}
		}

		//�ַ�������1
		counts++;
		
	}

	//����õ��µ������Ƶ�ԭ�����У��Է�����һ�εĵ���
	m_charRect=m_charRectCopy;

	//�������
	::GlobalUnlock (hDIB);


	::GlobalUnlock (hNewDIB);
	return hNewDIB;
}


/**************************************************
* �������ƣ�
*     ThinnerHilditch
*
* ������
*   void*     image             ����ֵ��ͼ�����ǰ��ɫΪ1����ɫΪ0
*   unsigned  longlx             ��ͼ��Ŀ��
*   unsigned  longly             ��ͼ��ĸ߶�
*
* ����ֵ
*       ��
*
*�������ܣ�
*       �������ͼ�����ϸ�������ϸ�����ͼ��
***********************************************************/

void ThinnerHilditch(void *image, unsigned long lx, unsigned long ly)
{
    char *f, *g;
    char n[10];
    unsigned int counter;
    short k, shori, xx, nrn;
    unsigned long i, j;
    long kk, kk11, kk12, kk13, kk21, kk22, kk23, kk31, kk32, kk33, size;
    size = (long)lx * (long)ly;
    g = (char *)malloc(size);

    if(g == NULL)
    {
       // printf("error in allocating memory!\n");
        return;
    }

    f = (char *)image;
    for(i=0; i<lx; i++)
    {
        for(j=0; j<ly; j++)
        {
            kk=i*ly+j;
            if(f[kk]!=0)
            {
                f[kk]=1;
                g[kk]=f[kk];
            }
        }
    }

    counter = 1;

    do
    {
        
        counter++;
        shori = 0;

        for(i=0; i<lx; i++)
        {
            for(j=0; j<ly; j++)
            {
                kk = i*ly+j;
                if(f[kk]<0)
                    f[kk] = 0;
                g[kk]= f[kk];
            }
        }

        for(i=1; i<lx-1; i++)
        {
            for(j=1; j<ly-1; j++)
            {
                kk=i*ly+j;

                if(f[kk]!=1)
                    continue;

                kk11 = (i-1)*ly+j-1;
                kk12 = kk11 + 1;
                kk13 = kk12 + 1;
                kk21 = i*ly+j-1;
                kk22 = kk21 + 1;
                kk23 = kk22 + 1;
                kk31 = (i+1)*ly+j-1;
                kk32 = kk31 + 1;
                kk33 = kk32 + 1;

                if((g[kk12]&&g[kk21]&&g[kk23]&&g[kk32])!=0)
                    continue;

                nrn = g[kk11] + g[kk12] + g[kk13] + g[kk21] + g[kk23] + 
                    g[kk31] + g[kk32] + g[kk33];

                if(nrn <= 1)
                {
                    f[kk22] = 2;
                    continue;
                }

                n[4] = f[kk11];
                n[3] = f[kk12];
                n[2] = f[kk13];
                n[5] = f[kk21];
                n[1] = f[kk23];
                n[6] = f[kk31];
                n[7] = f[kk32];
                n[8] = f[kk33];
                n[9] = n[1];
                xx = 0;

                for(k=1; k<8; k=k+2)
                {
                    if((!n[k])&&(n[k+1]||n[k+2]))
                        xx++;
                }

                if(xx!=1)
                {
                    f[kk22] = 2;
                    continue;
                }

                if(f[kk12] == -1)
                {
                    f[kk12] = 0;
                    n[3] = 0;
                    xx = 0;

                    for(k=1; k<8; k=k+2)
                    {
                        if((!n[k])&&(n[k+1]||n[k+2]))
                            xx++;
                    }

                    if(xx != 1)
                    {
                        f[kk12] = -1;
                        continue;
                    }

                    f[kk12] = -1;
                    n[3] = -1;
                }

                if(f[kk21]!=-1)
                {
                    f[kk22] = -1;
                    shori = 1;
                    continue;
                }

                f[kk21] = 0;
                n[5] = 0;
                xx = 0;

                for(k=1; k<8; k=k+2)
                {
                    if((!n[k])&&(n[k+1]||n[k+2]))
                    {
                        xx++;
                    }
                }

                if(xx == 1)
                {
                    f[kk21] = -1;
                    f[kk22] = -1;
                    shori =1;
                }
                else
                    f[kk21] = -1;
            }
        }
    }while(shori);

    free(g);
}

/**************************************************
* �������ƣ�
*     ThinnerRosenfeld
*
* ������
*   void*     image             ����ֵ��ͼ�����ǰ��ɫΪ1����ɫΪ0
*   unsigned  longlx             ��ͼ��Ŀ��
*   unsigned  longly             ��ͼ��ĸ߶�
*
* ����ֵ
*       ��
*
*�������ܣ�
*       �������ͼ�����ϸ�������ϸ�����ͼ��
***********************************************************/
void ThinnerRosenfeld(void *image, unsigned long lx, unsigned long ly)
{
    char *f, *g;
    char n[10];
    char a[5] = {0, -1, 1, 0, 0};
    char b[5] = {0, 0, 0, 1, -1};
    char nrnd, cond, n48, n26, n24, n46, n68, n82, n123, n345, n567, n781;
    short k, shori;
    unsigned long i, j;
    long ii, jj, kk, kk1, kk2, kk3, size;
    size = (long)lx * (long)ly;

    g = (char *)malloc(size);
    if(g==NULL)
    {
        printf("error in alocating mmeory!\n");
        return;
    }

    f = (char *)image;
    for(kk=0l; kk<size; kk++)
    {
        g[kk] = f[kk];
    }

    do
    {
        shori = 0;
        for(k=1; k<=4; k++)
        {
            for(i=1; i<lx-1; i++)
            {
                ii = i + a[k];

                for(j=1; j<ly-1; j++)
                {
                    kk = i*ly + j;

                    if(!f[kk])
                        continue;

                    jj = j + b[k];
                    kk1 = ii*ly + jj;

                    if(f[kk1])
                        continue;

                    kk1 = kk - ly -1;
                    kk2 = kk1 + 1;
                    kk3 = kk2 + 1;
                    n[3] = f[kk1];
                    n[2] = f[kk2];
                    n[1] = f[kk3];
                    kk1 = kk - 1;
                    kk3 = kk + 1;
                    n[4] = f[kk1];
                    n[8] = f[kk3];
                    kk1 = kk + ly - 1;
                    kk2 = kk1 + 1;
                    kk3 = kk2 + 1;
                    n[5] = f[kk1];
                    n[6] = f[kk2];
                    n[7] = f[kk3];

                    nrnd = n[1] + n[2] + n[3] + n[4]
                        +n[5] + n[6] + n[7] + n[8];
                    if(nrnd<=1)
                        continue;

                    cond = 0;
                    n48 = n[4] + n[8];
                    n26 = n[2] + n[6];
                    n24 = n[2] + n[4];
                    n46 = n[4] + n[6];
                    n68 = n[6] + n[8];
                    n82 = n[8] + n[2];
                    n123 = n[1] + n[2] + n[3];
                    n345 = n[3] + n[4] + n[5];
                    n567 = n[5] + n[6] + n[7];
                    n781 = n[7] + n[8] + n[1];

                    if(n[2]==1 && n48==0 && n567>0)
                    {
                        if(!cond)
                            continue;
                        g[kk] = 0;
                        shori = 1;
                        continue;
                    }

                    if(n[6]==1 && n48==0 && n123>0)
                    {
                        if(!cond)
                            continue;
                        g[kk] = 0;
                        shori = 1;
                        continue;
                    }

                    if(n[8]==1 && n26==0 && n345>0)
                    {
                        if(!cond)
                            continue;
                        g[kk] = 0;
                        shori = 1;
                        continue;
                    }

                    if(n[4]==1 && n26==0 && n781>0)
                    {
                        if(!cond)
                            continue;
                        g[kk] = 0;
                        shori = 1;
                        continue;
                    }

                    if(n[5]==1 && n46==0)
                    {
                        if(!cond)
                            continue;
                        g[kk] = 0;
                        shori = 1;
                        continue;
                    }

                    if(n[7]==1 && n68==0)
                    {
                        if(!cond)
                            continue;
                        g[kk] = 0;
                        shori = 1;
                        continue;
                    }

                    if(n[1]==1 && n82==0)
                    {
                        if(!cond)
                            continue;
                        g[kk] = 0;
                        shori = 1;
                        continue;
                    }

                    if(n[3]==1 && n24==0)
                    {
                        if(!cond)
                            continue;
                        g[kk] = 0;
                        shori = 1;
                        continue;
                    }

                    cond = 1;
                    if(!cond)
                        continue;
                    g[kk] = 0;
                    shori = 1;
                }
            }

            for(i=0; i<lx; i++)
            {
                for(j=0; j<ly; j++)
                {
                    kk = i*ly + j;
                    f[kk] = g[kk];
                }
            }
        }
    }while(shori);

    free(g);
}              


/*************************************************
*
* �������ƣ�
*       CharSegment()
*
*  ������
*      HDIB  hDIB      ��ԭͼ��ľ��
*
*  ����ֵ��
*     CRectLink        ����ű��ָ�ĸ����ַ�λ����Ϣ������
*
* ���ܣ�
*    ��ͼ���д�ʶ����ַ����������������ش�Ÿ����ַ���λ����Ϣ������
*
*  ˵����
*    �˺���ֻ�ܶ�2ֵ�����ͼ����д���
*
*********************************************************/


CRectLink CharSegment(HANDLE hDIB)
{
	
	//�����������ÿ���ַ����������
	CRectLink charRect1,charRect2;
	charRect1.clear();
	charRect2.clear();

	// ָ��DIB��ָ��
	LPSTR lpDIB=(LPSTR) ::GlobalLock((HGLOBAL)hDIB);
	
	// ָ��DIB����ָ��
	LPSTR    lpDIBBits;	

	// �ҵ�DIBͼ��������ʼλ��
	lpDIBBits = ::FindDIBBits(lpDIB);
	
	//ָ�����صĵ�ָ��
	BYTE* lpSrc;

	//ͼ��ĳ��ȺͿ��
	int height,width;

	//��ȡͼ��Ŀ��
	width=(int)::DIBWidth(lpDIB);

	//��ȡͼ��ĳ���
	height=(int)::DIBHeight(lpDIB);

	//����ͼ��ÿ�е��ֽ���
	LONG	lLineBytes = WIDTHBYTES(width * 8);

	//�������±߽���������
	int top,bottom;

    //���صĻҶ�ֵ
    int gray; 

	//����ѭ������
	int i,j;

	//����ͳ��ͼ�����ַ������ļ�����
	digicount=0;


	//��������ɨ�裬�ҵ��ϱ߽�

	//��
	for (i=0;i<height;i++)
	{
         //��
  		for (j=0;j<width;j++)
		{
            // ָ��ͼ���i�У���j�����ص�ָ��
			lpSrc = (unsigned char*)lpDIBBits + lLineBytes * i + j;

			//��øõ�ĻҶ�ֵ
			gray = *(lpSrc);

			//���Ƿ�Ϊ�ڵ�
			if (gray == 0)
			{   
               //��Ϊ�ڵ㣬�Ѵ˵���Ϊ�ַ����µ���ߵ�
				top = i;

				//��iǿ�и�ֵ���ж�ѭ��
				i=height;

				//����ѭ��
				break;
			}

        //����õ㲻�Ǻڵ㣬����ѭ��
		}
	}


    //��������ɨ�裬���±߽�

	//��
	for (i = height-1;i>=0;i--)
    {

		//��
		for (j=0;j<width;j++)
		{
			// ָ��ͼ���i�У���j�����ص�ָ��
			lpSrc = (unsigned char*)lpDIBBits + lLineBytes * i + j;

			//��ȡ�õ�ĻҶ�ֵ
			gray = *(lpSrc);

			//�ж��Ƿ�Ϊ�ڵ�
			if (gray == 0)
			{
				//��Ϊ�ڵ㣬�Ѵ˵���Ϊ�ַ����µ���͵�
				bottom = i;

				//��iǿ�и�ֵ���ж�ѭ��
				i=-1;

				//����ѭ��
				break;
			}

          //����õ㲻�Ǻڵ㣬����ѭ��
		}
	
	}

	//lab �����Ƿ����һ���ַ��ָ�ı�־
	bool lab = false;

	//����ɨ��һ�����Ƿ��ֺ�ɫ��
	bool black = false;

    //���λ����Ϣ�Ľṹ��
	CRect rect;

	//����������
	digicount=0;
   
	//��
	for (i=0;i<width;i++)
	{
		//��ʼɨ��һ��
		black=false;

		for (j=0;j<height;j++)
			{	
				// ָ��ͼ���i�У���j�����ص�ָ��
				lpSrc = (unsigned char*)lpDIBBits + lLineBytes * j + i;

				//��ȡ�õ�ĻҶ�ֵ
				gray = *(lpSrc);

                //�ж��Ƿ�Ϊ�ڵ�
				if (gray == 0)
				{
					//������ֺڵ㣬���ñ�־λ
					black=true;

					//�����û�н���һ���ַ��ķָ�
					if(lab==false)
					{	
						//�������߽�
						rect.left = i;

						//�ַ��ָʼ
						lab = true;
					}

					//����ַ��ָ��Ѿ���ʼ��
					else

                      //����ѭ��
						break;
				}		
			}

		//����Ѿ�ɨ�������ұ����У�˵������ͼ��ɨ����ϡ��˳�
           if(i==(width-1))
			   
		 //�˳�����ѭ��	   
		   break;

		//�������black��Ϊfalse��˵��ɨ����һ�У���û�з��ֺڵ㡣������ǰ�ַ��ָ����
		if(lab==true&&black==false)
		{   
           //��λ����Ϣ����ṹ����

           //�����ұ߽�
			rect.right =i;

			//�����ϱ߽�
			rect.top =top;

			//�����±߽�
			rect.bottom =bottom;

			//��������һ�����أ�����ѹ���ַ�
			rect.InflateRect (1,1);

            //������ṹ�������λ����Ϣ������1�ĺ���
			charRect1.push_back (rect);

			//���ñ�־λ����ʼ��һ�ε��ַ��ָ�
			lab=false;

			//�ַ�����ͳ�Ƽ�������1
			digicount++;
			
		}

		//������һ�е�ɨ��

	}

   //�ٽ������������ε�top��bottom��ȷ��

	//������1��ֵ������2
	charRect2=charRect1;

    //������2���������
    charRect2.clear ();

	//����һ���µĴ��λ����Ϣ�Ľṹ��
	CRect rectnew;

	//��������1��ͷ��β�������ɨ��
	while(!charRect1.empty())
	{    
		//������1ͷ�ϵõ�һ������
		rect= charRect1.front();

		//������1ͷ����ɾ��һ��
		charRect1.pop_front();

		//������Ӿ�ȷ�ľ�������

		//��þ�ȷ����߽�
		rectnew.left =rect.left-1 ;

		//��þ�ȷ���ұ߽�
		rectnew.right =rect.right+1 ;

		//ͨ����õľ�ȷ���ұ߽�����±߾����½��о�ȷ��λ

		// ���¶���ɨ������ϱ߽�
		
		//��
		for(i=rect.top ;i<rect.bottom ;i++)
		{   
          //��
			for(j=rect.left ;j<rect.right ;j++)
			{   
                 // ָ��ͼ���i�У���j�����ص�ָ��
				lpSrc = (unsigned char*)lpDIBBits + lLineBytes * i + j;

				//�����������Ǻڵ�
				if (*lpSrc == 0)
				{	
					//�����ϱ߽�
					rectnew.top = i-1;
					
					//��i����ǿ�ƶ���������ѭ��
					i=rect.bottom  ;

					//����ѭ��
					break;
				}	
			}
		}

		//���¶���ɨ������±߽�
   
        //��
		for(i=rect.bottom-1 ;i>=rect.top  ;i--)
		{
			//��
			for(j=rect.left ;j<rect.right ;j++)
			{
				// ָ��ͼ���i�У���j�����ص�ָ��
				lpSrc = (unsigned char*)lpDIBBits + lLineBytes * i + j;

				//�õ����Ϊ�ڵ�
				if (*lpSrc == 0)
				{	
					//�����±߽�
					rectnew.bottom = i+1;

                    //��i����ǿ�ƶ���������ѭ��
					i=-1;
                    //����ѭ��
					break;
				}	
			}
		}

		//���õ����µ�׼ȷ��λ����Ϣ�Ӻ���嵽����2��β��
		charRect2.push_back (rectnew);
	}

	//������2 ���ݸ�����1
	charRect1=charRect2;
	
	//�������
	::GlobalUnlock(hDIB);

	//������1����
	return charRect1;
}

/****************************************************************
* �������ƣ�
*      Convert256toGray()
*
* ������
*     HDIB hDIB     ��ͼ��ľ��
*
*  ����ֵ��
*        ��
*
*  ���ܣ�
*     ��256ɫλͼת��Ϊ�Ҷ�ͼ
*
***************************************************************/

void Convert256toGray(HDIB hDIB)
{
	LPSTR	lpDIB;
	
	// ��DIB����õ�DIBָ�벢����DIB
lpDIB = (LPSTR) ::GlobalLock((HGLOBAL)hDIB);
	
	// ָ��DIB������������ָ��
	LPSTR   lpDIBBits;	

	// ָ��DIB���ص�ָ��
	BYTE *	lpSrc;	

	// ͼ����
	LONG	lWidth;	
	// ͼ��߶�
LONG  	lHeight;	

	// ͼ��ÿ�е��ֽ���
	LONG	lLineBytes;	

	// ָ��BITMAPINFO�ṹ��ָ�루Win3.0��
	LPBITMAPINFO lpbmi;	

	// ָ��BITMAPCOREINFO�ṹ��ָ��
	LPBITMAPCOREINFO lpbmc;
	
	// ��ȡָ��BITMAPINFO�ṹ��ָ�루Win3.0��
	lpbmi = (LPBITMAPINFO)lpDIB;	

	// ��ȡָ��BITMAPCOREINFO�ṹ��ָ��
	lpbmc = (LPBITMAPCOREINFO)lpDIB;	

	// �Ҷ�ӳ���
	BYTE bMap[256];
	
	// ����Ҷ�ӳ������������ɫ�ĻҶ�ֵ����������DIB��ɫ��
	int	i,j;
	for (i = 0; i < 256; i ++)
	{
		// �������ɫ��Ӧ�ĻҶ�ֵ
		bMap[i] = (BYTE)(0.299 * lpbmi->bmiColors[i].rgbRed +

					     0.587 * lpbmi->bmiColors[i].rgbGreen +

				         0.114 * lpbmi->bmiColors[i].rgbBlue + 0.5);			
		// ����DIB��ɫ���ɫ����
		lpbmi->bmiColors[i].rgbRed = i;	
		
		// ����DIB��ɫ����ɫ����
		lpbmi->bmiColors[i].rgbGreen = i;	
		
		// ����DIB��ɫ����ɫ����
		lpbmi->bmiColors[i].rgbBlue = i;
			
		// ����DIB��ɫ�屣��λ
		lpbmi->bmiColors[i].rgbReserved = 0;

	}
	// �ҵ�DIBͼ��������ʼλ��
	lpDIBBits = ::FindDIBBits(lpDIB);
		
	// ��ȡͼ����
	lWidth = ::DIBWidth(lpDIB);	

	// ��ȡͼ��߶�
	lHeight = ::DIBHeight(lpDIB);	

	// ����ͼ��ÿ�е��ֽ���
	lLineBytes = WIDTHBYTES(lWidth * 8);	

// ����ÿ�����ص���ɫ�����������ջҶ�ӳ����ɻҶ�ֵ��

//����ɨ��
for(i = 0; i < lHeight; i++)
{

  //����ɨ��
for(j = 0; j < lWidth; j++)
{
	// ָ��DIB��i�У���j�����ص�ָ��
	lpSrc = (unsigned char*)lpDIBBits + lLineBytes * (lHeight - 1 - i) + j;
			
	// �任
	*lpSrc = bMap[*lpSrc];
}
}

//�������
::GlobalUnlock ((HGLOBAL)hDIB);
}

/******************************************************************
*
* ��������ConvertGrayToWhiteBlack()
*
* ���� ��HDIB hDIB     ��ԭͼ�ľ��
*
* ����ֵ����
*
* ����: ConvertGrayToWhiteBlack��������Ӳ��ֵ�ķ�����ʵ�ֽ�ͼ���ֵ���Ĺ��ܡ�
* 
* ˵����
Ҫ��������ͼƬΪ256ɫ
************************************************************************/

void ConvertGrayToWhiteBlack(HDIB hDIB)
{
	// ָ��DIB��ָ��
	LPSTR	lpDIB;
	
	// ��DIB����õ�DIBָ�벢����DIB
	lpDIB = (LPSTR) ::GlobalLock((HGLOBAL)hDIB);
	
	// ָ��DIB������������ָ��
	LPSTR   lpDIBBits;
	
	// ָ��DIB���ص�ָ��
	BYTE *	lpSrc;	

	// ͼ����
	LONG	lWidth;	

	// ͼ��߶�
	LONG	lHeight;	
	// ͼ��ÿ�е��ֽ���
	LONG	lLineBytes;	

	// �ҵ�DIBͼ��������ʼλ��
	lpDIBBits = ::FindDIBBits(lpDIB);	
	
	// ��ȡͼ����
	lWidth = ::DIBWidth(lpDIB);	

	// ��ȡͼ��߶�
	lHeight = ::DIBHeight(lpDIB);	

	// ����ͼ��ÿ�е��ֽ���
	lLineBytes = WIDTHBYTES(lWidth * 8);	

	// ����ÿ�����ص���ɫ�����������ջҶ�ӳ����ɻҶ�ֵ��
	int i,j;

    //����ɨ��
	for(i = 0; i < lHeight; i++)
 {

   //����ɨ��
	for(j = 0; j < lWidth; j++)
	{

	// ָ��DIB��i�У���j�����ص�ָ��
	lpSrc = (unsigned char*)lpDIBBits + lLineBytes * i + j;

	// ��ֵ������

   //����220������Ϊ255�����׵�
	if(*lpSrc>220) *lpSrc=255;

  //��������Ϊ0�����ڵ�
	else *lpSrc=0;

	}

}
	
 //�������
::GlobalUnlock((HGLOBAL)hDIB);
}

/*****************************************************************
*
*  �������� 
*       DeleteScaterJudge()
*
*  ������
*     LPSTR   lpDIBBits      ��ָ��������ʼλ�õ�ָ��
*	  WORD    lLineBytes     ��ͼ��ÿ�е��ֽ���
*     LPBYTE  lplab          ����־λ����
*     int     lWidth         ��ͼ��Ŀ��
*	  int     lHeight        ��ͼ��ĸ߶�
*     int     x              ����ǰ��ĺ�����
*	  int     y              ����ǰ��������� 
*     CPoint  lab[]          ������鿼���������������
*     int     lianXuShu      ����ɢ����ж�����
*
*  ����ֵ��
*     Bool                   ������ɢ�㷵��false ������ɢ�㷵��true
*	 
*  ���ܣ�
*     ���õݹ��㷨ͳ��������ĸ�����ͨ����ֵ���ж��Ƿ�Ϊ��ɢ��
*
*  ˵����
*     ֻ�ܶ�2ֵͼ����д���
******************************************************************/     


bool DeleteScaterJudge(LPSTR lpDIBBits, WORD lLineBytes, LPBYTE lplab, int lWidth, int lHeight, int x, int y, CPoint lab[], int lianXuShu)
{
	
	//���������������Ҫ��˵��������ɢ�㣬����
	if(m_lianXuShu>=lianXuShu)
		return TRUE;

	//���ȼ�һ
	m_lianXuShu++;

	//�趨���ʱ�־
	lplab[lWidth * y +x] = true;
	
	//������ʵ�����
	lab[m_lianXuShu-1].x = x;
	lab[m_lianXuShu-1].y = y;

	//���صĻҶ�ֵ
	int gray;
  
	//ָ�����ص�ָ��
	LPSTR lpSrc;

	//�����ж�
    //���������������Ҫ��˵��������ɢ�㣬����
	if(m_lianXuShu>=lianXuShu)
		return TRUE;
	
	//�������ݹ�
	else
	{	
		//�������������Լ����ϡ����ϡ����¡����°˸�����
		//����Ǻ�ɫ�㣬����ú���������еݹ�

		//���������
		
		lpSrc=(char*)lpDIBBits + lLineBytes * (y-1) + x;

		//���ݻҶ�ֵ
		gray=*lpSrc;

		//�������ͼ���ڡ���ɫΪ��ɫ����û�б����ʹ�
		if(y-1 >=0 && gray == 0 && lplab[(y-1)*lWidth+x] == false)

		//���еݹ鴦��		
		DeleteScaterJudge(lpDIBBits,lLineBytes,lplab,lWidth,lHeight,x,y-1,lab,lianXuShu);

		//�жϳ���
		//���������������Ҫ��˵��������ɢ�㣬����
		if(m_lianXuShu>=lianXuShu)
		return TRUE;
		
		//���µ�
		
		lpSrc=(char*)lpDIBBits + lLineBytes * (y-1) + x-1;

        //���ݻҶ�ֵ
		gray=*lpSrc;

        //�������ͼ���ڡ���ɫΪ��ɫ����û�б����ʹ�
		if(y-1 >=0 &&  x-1 >=0 && gray== 0 && lplab[(y-1)*lWidth+x-1] == false)

      	//���еݹ鴦��		
		DeleteScaterJudge(lpDIBBits,lLineBytes,lplab,lWidth,lHeight,x-1,y-1,lab,lianXuShu);

        //�жϳ���
		//���������������Ҫ��˵��������ɢ�㣬����
		if(m_lianXuShu>=lianXuShu)
		return TRUE;
		
		//���
		
		lpSrc=(char*)lpDIBBits + lLineBytes * y + x-1;

		//���ݻҶ�ֵ
		gray=*lpSrc;

        //�������ͼ���ڡ���ɫΪ��ɫ����û�б����ʹ�
		if(x-1 >=0 &&  gray== 0 && lplab[y*lWidth+x-1] == false)

        //���еݹ鴦��		
		DeleteScaterJudge(lpDIBBits,lLineBytes,lplab,lWidth,lHeight,x-1,y,lab,lianXuShu);

        //�жϳ���
		//���������������Ҫ��˵��������ɢ�㣬����
		if(m_lianXuShu>=lianXuShu)
			return TRUE;
		
		//����
		
		lpSrc=(char*)lpDIBBits + lLineBytes * (y+1) + x-1;

		//���ݻҶ�ֵ
		gray=*lpSrc;

        //�������ͼ���ڡ���ɫΪ��ɫ����û�б����ʹ�
		if(y+1 <lHeight && x-1 >= 0 && gray == 0 && lplab[(y+1)*lWidth+x-1] == false)

		//���еݹ鴦��
		
		DeleteScaterJudge(lpDIBBits,lLineBytes,lplab,lWidth,lHeight,x-1,y+1,lab,lianXuShu);

        //�жϳ���
		//���������������Ҫ��˵��������ɢ�㣬����
		if(m_lianXuShu>=lianXuShu)
			return TRUE;
		
		//����
		
		lpSrc=(char*)lpDIBBits + lLineBytes * (y+1) + x;

        //���ݻҶ�ֵ
		gray=*lpSrc;

        //�������ͼ���ڡ���ɫΪ��ɫ����û�б����ʹ�
		if(y+1 < lHeight && gray == 0 && lplab[(y+1)*lWidth+x] == false)

        //���еݹ鴦��
		
		DeleteScaterJudge(lpDIBBits,lLineBytes,lplab,lWidth,lHeight,x,y+1,lab,lianXuShu);

        //�жϳ���
		//���������������Ҫ��˵��������ɢ�㣬����
		if(m_lianXuShu>=lianXuShu)
			return TRUE;
		
		//����
		
		lpSrc=(char*)lpDIBBits + lLineBytes * (y+1) + x+1;
        
		//���ݻҶ�ֵ
		gray=*lpSrc;

        //�������ͼ���ڡ���ɫΪ��ɫ����û�б����ʹ�
		if(y+1 <lHeight && x+1 <lWidth &&  gray == 0 && lplab[(y+1)*lWidth+x+1] == false)

        //���еݹ鴦��
		DeleteScaterJudge(lpDIBBits,lLineBytes,lplab,lWidth,lHeight,x+1,y+1,lab,lianXuShu);

        //�жϳ���
		//���������������Ҫ��˵��������ɢ�㣬����
		if(m_lianXuShu>=lianXuShu)
			return TRUE;
		
		//�ұ�
	
		lpSrc=(char*)lpDIBBits + lLineBytes * y + x+1;

        //���ݻҶ�ֵ
		gray=*lpSrc;

		//�������ͼ���ڡ���ɫΪ��ɫ����û�б����ʹ�
		if(x+1 <lWidth && gray==0 && lplab[y*lWidth+x+1] == false)

        //���еݹ鴦��		
		DeleteScaterJudge(lpDIBBits,lLineBytes,lplab,lWidth,lHeight,x+1,y,lab,lianXuShu);

        //�жϳ���

		//���������������Ҫ��˵��������ɢ�㣬����
		if(m_lianXuShu>=lianXuShu)
			return TRUE;
		
		//����
		
		lpSrc=(char*)lpDIBBits + lLineBytes * (y-1) + x+1;

        //���ݻҶ�ֵ
		gray=*lpSrc;

        //�������ͼ���ڡ���ɫΪ��ɫ����û�б����ʹ�
		if(y-1 >=0 && x+1 <lWidth && gray == 0 && lplab[(y-1)*lWidth+x+1] == false)

       //���еݹ鴦��		
	   DeleteScaterJudge(lpDIBBits,lLineBytes,lplab,lWidth,lHeight,x+1,y-1,lab,lianXuShu);

        //�жϳ���
		//���������������Ҫ��˵��������ɢ�㣬����
		if(m_lianXuShu>=lianXuShu)
			return TRUE;
	}
	

	//����ݹ����������false��˵������ɢ��
	return FALSE;

}


/*****************���������ַ�����ľ��ο�*******************/
void DrawFrame(CDC* pDC,HDIB hDIB, CRectLink charRect,unsigned int linewidth,COLORREF color)
{	
	CPen pen;
	pen.CreatePen (PS_SOLID,linewidth,color);
	pDC->SelectObject (&pen);
	::SelectObject (*pDC,GetStockObject(NULL_BRUSH));
	CRect rect,rect2;
	BYTE* lpDIB=(BYTE*)::GlobalLock ((HGLOBAL)hDIB);
	while(!charRect.empty())
	{
		
		//�ӱ�ͷ�ϵõ�һ������
		rect2=rect= charRect.front();
		//������ͷ����ɾ��һ��
		charRect.pop_front();
		//ע�⣬����ԭ�ȵ�rect�������ͼ��ԭ��(���½�)�ģ�
		//������Ļ�ϻ�ͼʱ��Ҫת���Կͻ���Ϊԭ�������
		rect.top =::DIBHeight ((char*)lpDIB)-rect2.bottom;
		rect.bottom =::DIBHeight ((char*)lpDIB)-rect2.top ;
		pDC->Rectangle (&rect);
	}
	::GlobalUnlock ((HGLOBAL)hDIB);
}
/***********************************************
*
* �������ƣ�
*   GradientSharp() 
*
*���� ��
*  HDIB hDIB    -������ͼ��ľ��
*
* ����ֵ��
*       ��
* 
*���ܣ�
*    ��ͼ����ݶ���

*˵����
*    ֻ�ܶ�2ֵͼ����д������ͼ�����Ե��ϸ�����������Ϣ����ʧ
**********************************************************************/
void GradientSharp(HDIB hDIB)
{
	// ָ��DIB��ָ��
	LPSTR lpDIB=(LPSTR) ::GlobalLock((HGLOBAL)hDIB);

	// ָ��DIB����ָ��
	LPSTR    lpDIBBits;	

	// �ҵ�DIBͼ��������ʼλ��
	lpDIBBits = ::FindDIBBits(lpDIB);	

    //��ȡͼ��Ŀ��
	LONG lWidth=::DIBWidth ((char*)lpDIB);

    //��ȡͼ��ĳ���
	LONG lHeight=::DIBHeight ((char*)lpDIB);

    // ��ֵ
	BYTE	bThre = 2;

	// ����GradSharp()���������ݶȰ���

	// ָ��Դͼ���ָ��
	unsigned char*	lpSrc;
	unsigned char*	lpSrc1;
	unsigned char*	lpSrc2;
	
	// ѭ������
	LONG	i;
	LONG	j;
	
	// ͼ��ÿ�е��ֽ���
	LONG	lLineBytes;
	
	// �м����
	BYTE	bTemp;
	
	// ����ͼ��ÿ�е��ֽ���
	lLineBytes = WIDTHBYTES(lWidth * 8);
	
	// ÿ��
   for(i = 0; i < lHeight; i++)
	{
		
     // ÿ��
	 for(j = 0; j < lWidth; j++)
		{
			
             // ָ��DIB��i�У���j�����ص�ָ��
			lpSrc  = (unsigned char*)lpDIBBits + lLineBytes * (lHeight - 1 - i) + j;
			
			// ָ��DIB��i+1�У���j�����ص�ָ��
			lpSrc1 = (unsigned char*)lpDIBBits + lLineBytes * (lHeight - 2 - i) + j;
			
		     // ָ��DIB��i�У���j+1�����ص�ָ��
		     lpSrc2 = (unsigned char*)lpDIBBits + lLineBytes * (lHeight - 1 - i) + j + 1;
			

              //�����ݶ�ֵ
		     bTemp = abs((*lpSrc)-(*lpSrc1)) + abs((*lpSrc)-(*lpSrc2));
			
		    // �ж��Ƿ�С����ֵ
		    if (bTemp < 255)
			{  

		     // �ж��Ƿ������ֵ������С��������Ҷ�ֵ���䡣
			   if (bTemp >= bThre)
			   {

			// ֱ�Ӹ�ֵΪbTemp
			 *lpSrc = bTemp;

			   }

			}
			
           else
			{
				// ֱ�Ӹ�ֵΪ255
				*lpSrc = 255;
			}
	 }
   }

//���Ҫ����һ��ͼ��������������
for(j = 0; j < lWidth; j++)
{   
	
 //ָ�����±�һ�У���j�����ص�ָ��
  lpSrc  = (unsigned char*)lpDIBBits + lLineBytes * 0 + j;

   //����λ�õ���������Ϊ255�����׵�
	*lpSrc=255;
}

   //�������
	::GlobalUnlock ((HGLOBAL)hDIB);
}


/************************************************************
*
*  �������ƣ�
*       RemoveScatterNoise()
*
*  ������
*     HDIB    hDIB     ��ԭͼ��ľ��
*
*  ����ֵ:
*       ��
*
*  ���ܣ�
*     ͨ���������㳤�ȵ�ͳ����ȥ����ɢ�ӵ�
*
*  ˵����
*      ֻ�ܶ�2ֵͼ����д���
****************************************************************/
void RemoveScatterNoise(HDIB hDIB)
{
	
	// ָ��DIB��ָ��
	LPSTR lpDIB=(LPSTR) ::GlobalLock((HGLOBAL)hDIB);
	
	// ָ��DIB����ָ��
	LPSTR    lpDIBBits;	

	// �ҵ�DIBͼ����������������ʼλ��
	lpDIBBits = ::FindDIBBits(lpDIB);
	
	//���ͼ��ĳ���
	LONG lWidth=::DIBWidth ((char*)lpDIB);

	//���ͼ��ĸ߶�
	LONG lHeight=::DIBHeight ((char*)lpDIB);

	//�����ж������ĳ�����ֵΪ15
	//������뿼��������ӵĺڵ����ĿС��15����Ϊ�������������
	int length=15;
	
	// ѭ������
	m_lianXuShu=0;
	LONG	i;
	LONG	j;	
	LONG    k;

	// ͼ��ÿ�е��ֽ���
	LONG	lLineBytes;

	// ����ͼ��ÿ�е��ֽ���
	lLineBytes = WIDTHBYTES(lWidth * 8);

    
	LPSTR lpSrc;

	//����һ��������ű�־���ڴ�����
	LPBYTE lplab = new BYTE[lHeight * lWidth];

	//����һ������������ɢ�ж�������ڴ�����
	bool *lpTemp = new bool[lHeight * lWidth];

    //��ʼ����־����
	for (i=0;i<lHeight*lWidth;i++)
    {

    //�����еı�־λ����Ϊ��
	lplab[i] = false;

	}

	//���������ɢ������������
	CPoint lab[21];
   
	//Ϊѭ����������ʼֵ
	k=0;

	//ɨ������ͼ��

	//����ɨ��
	for(i =0;i<lHeight;i++)
	{  
       
	   //����ɨ��
		for(j=0;j<lWidth;j++)
			{	
				//�Ȱѱ�־λ��false
				for(k=0;k<m_lianXuShu;k++)
				lplab[lab[k].y * lWidth + lab[k].x] = false;

				//��������0
				m_lianXuShu =0;

			    //������ɢ���ж�
			    lpTemp[i*lWidth+j] = DeleteScaterJudge(lpDIBBits,(WORD)lLineBytes,lplab,lWidth,lHeight,j,i,lab,length);

			}
	}
			
	//ɨ������ͼ�񣬰���ɢ�����ɰ�ɫ

	//����ɨ��
	for(i = 0;i<lHeight;i++)
	{

      //����ɨ��
		for(j=0;j<lWidth;j++)
		{       
			    //�鿴��־λ,���Ϊ���򽫴˵���Ϊ�׵�
				if(lpTemp[i*lWidth+j] == false)
				{	
                   //ָ���i�е�j�����ص�ָ��
					lpSrc=(char*)lpDIBBits + lLineBytes * i + j;

					//����������Ϊ�׵�
					*lpSrc=BYTE(255);
				}
			}
	}

	//�������
	::GlobalUnlock ((HGLOBAL)hDIB);

}

/*********************************************************

* �������ƣ�
*         SlopeAdjust()
*
* ������
*     HDIB   hDIB       ��ԭͼ��ľ��
*
* ����ֵ��
*         ��
*
* ���ܣ�
*     ͨ����ͼ�����Ұ��ƽ���߶ȵ�ͳ����������б�ĵ���
*
* ˵����
*      ֻ�ܶ�2ֵͼ����д���
*
****************************************************************/
void SlopeAdjust(HDIB hDIB)
{
	// ָ��DIB��ָ��
	LPSTR lpDIB=(LPSTR) ::GlobalLock((HGLOBAL)hDIB);
	
	// ָ��DIB����ָ��
	LPSTR    lpDIBBits;	

	// �ҵ�DIBͼ��������ʼλ��
	lpDIBBits = ::FindDIBBits(lpDIB);
	
	// ָ��Դͼ���ָ��
	unsigned char*	lpSrc;

	// ѭ������
	LONG	i;
	LONG	j;
	
	// ͼ��ÿ�е��ֽ���
	LONG	lLineBytes;

	//ͼ��ĳ���
	LONG    lWidth;

	//ͼ��Ŀ��
	LONG	lHeight;

	//��ȡͼ��ĳ���
	lWidth=::DIBWidth ((char*)lpDIB);

	//��ȡͼ��Ŀ��
	lHeight=::DIBHeight ((char*)lpDIB);

	// ����ͼ��ÿ�е��ֽ���
	lLineBytes = WIDTHBYTES(lWidth * 8);
    
	//ͼ�����ߵ�ƽ���߶�
	double leftaver=0.0;

   //ͼ���Ұ�ߵ�ƽ���߶�
	double rightaver=0.0;

	//ͼ�����б��
	double slope;

	//ͳ��ѭ������
	LONG counts=0;
	
	//ɨ�����ߵ�ͼ�����ɫ���ص�ƽ���߶�

	//��
	for (i=0;i<lHeight;i++)
	{   

      //��
		for (j=0;j<lWidth/2;j++)
		{
		 
		 //ָ���i�е�j�����ص�ָ��	
		 lpSrc=(unsigned char*)lpDIBBits + lLineBytes *  i + j;
      
		 //���Ϊ�ڵ�
		 if (*lpSrc == 0)
		 {
          
          //����߶Ƚ���ͳ�Ƶ���
		  counts +=lWidth/2 -j;
		  leftaver += i*(lWidth/2 -j);

		 }

		}
	}

    //����ƽ���߶�
	leftaver /= counts;
	
	//��ͳ��ѭ���������¸�ֵ
	counts =0;

	//ɨ���Ұ�ߵ�ͼ�����ɫ���ص�ƽ���߶�

	//��
	for (i =0;i<lHeight;i++)
	{

       //��
		for (j=lWidth/2;j<lWidth;j++)
		{
			//ָ���i�е�j�����ص�ָ��
			lpSrc=(unsigned char*)lpDIBBits + lLineBytes *  i + j;

            //���Ϊ�ڵ�
			if (*lpSrc == 0)
				{

				  //����ͳ�Ƶ���
					counts +=lWidth -j;
					rightaver += i*(lWidth -j);
				}
			}
	}

	//�����Ұ�ߵ�ƽ���߶�
	rightaver /= counts;
	
	//����б��
	slope = (leftaver - rightaver) / (lWidth/2);

	//ָ���µ�ͼ��������ʼλ�õ�ָ��
	LPSTR lpNewDIBBits;
   
	//ָ����ͼ���ָ��
	LPSTR lpDst;
    
	//��ͼ��ľ��
	HLOCAL nNewDIBBits=LocalAlloc(LHND,lLineBytes*lHeight);
    
	//�����ڴ�
	lpNewDIBBits=(char*)LocalLock(nNewDIBBits);
    
	//ָ����ͼ�����ص�ָ��
	lpDst=(char*)lpNewDIBBits;
    
	//Ϊ��ͼ�񸳳�ʼֵ
	memset(lpDst,(BYTE)255,lLineBytes*lHeight);
    
	//���ص�ĻҶ�ֵ
	int gray;
    
	//λ��ӳ��ֵ
	int i_src;

	//����б�ʣ��ѵ�ǰ��ͼ��ĵ�ӳ�䵽Դͼ��ĵ�

	//��
	for (i=0;i<lHeight;i++)
	{
		//��
   		for (j=0;j<lWidth;j++)
		{	
		   //����ӳ��λ��	
			i_src=int(i - (j-lWidth/2)*slope);

			//�������ͼ���⣬�����ð�ɫ
			if (i_src <0 || i_src >=lHeight )
				gray = 255;

			else
			{	
				//����Դͼ�����ҵ㣬ȡ������ֵ

				//ָ���i_src�е�j�����ص�ָ��
				lpSrc=(unsigned char *)lpDIBBits + lLineBytes *  i_src + j;
				gray = *lpSrc;
			}
			
			//����ͼ��ĵ��õõ�������ֵ���
            //ָ���i�е�j�����ص�ָ��
			lpDst = (char *)lpNewDIBBits + lLineBytes * i + j;
			*lpDst=gray;
		}
	}

	// ���µ�ͼ������ݿ������ɵ�ͼ����
	memcpy(lpDIBBits,lpNewDIBBits,lLineBytes*lHeight);

   // �������
	::GlobalUnlock ((HGLOBAL)hDIB);
}



/******************************************************************
*
*  �������ƣ�
*      StdDIBbyRect()
*
*  ������
*     HDIB  hDIB          ��ͼ��ľ��
*     int   tarWidth      ����׼���Ŀ��
*     int   tarHeight     ����׼���ĸ߶�
*
*  ����ֵ��
*         ��
*
*  ���ܣ�
*     �������ָ���ַ����������Ŵ���ʹ���ǵĿ�͸�һֱ���Է�����������ȡ
*
*  ˵����
*     �������õ��ˣ�ÿ���ַ���λ����Ϣ�����Ա�����ִ����ָ����֮�����ִ�б�׼������
*
******************************************************************/
void StdDIBbyRect(HDIB hDIB, int tarWidth, int tarHeight)
{	

	//ָ��ͼ���ָ��
	BYTE* lpDIB=(BYTE*)::GlobalLock ((HGLOBAL)hDIB);

	//ָ��������ʼλ�õ�ָ��
	BYTE* lpDIBBits=(BYTE*)::FindDIBBits ((char*)lpDIB);
	
	//ָ�����ص�ָ��
	BYTE* lpSrc;

	//��ȡͼ��ĵĿ��
	LONG lWidth=::DIBWidth ((char*)lpDIB);

	//��ȡͼ��ĸ߶�
	LONG lHeight=::DIBHeight ((char*)lpDIB);

	// ѭ������
	int	i;
	int	j;
	
	// ͼ��ÿ�е��ֽ���
	LONG	lLineBytes = WIDTHBYTES(lWidth * 8);

	//��ȡ��߶ȷ����ϵ���������
	double wscale,hscale;

	//����һ����ʱ������,����ű仯���ͼ����Ϣ
	LPSTR lpNewDIBBits;
	LPSTR lpDst;
 
    //�������Ĵ�С��ԭͼ�����������Сһ��
	HLOCAL nNewDIBBits=LocalAlloc(LHND,lLineBytes*lHeight);

	//ָ�򻺴�����ʼλ�õ�ָ��
	lpNewDIBBits=(char*)LocalLock(nNewDIBBits);

	//ָ�򻺴�����Ϣ��ָ��
	lpDst=(char*)lpNewDIBBits;

	//�������������ݸ���ʼֵ
	memset(lpDst,(BYTE)255,lLineBytes*lHeight);

	//����ӳ��������������
	int i_src,j_src;

	//����ַ�λ����Ϣ�Ľṹ��
	CRect rect;
	CRect rectnew;

	//�����һ���µľ������������Ա�洢��׼����ľ�����������
	m_charRectCopy.clear ();

	//��ͷ��β���ɨ��������
	while(!m_charRect.empty())
	{
		//�ӱ�ͷ�ϵõ�һ������
		rect= m_charRect.front();

		//������ͷ����ɾ��һ��
		m_charRect.pop_front();

		//������������

		//�����귽�����������
		wscale=(double)tarWidth/rect.Width ();

		//�����귽�����������
		hscale=(double)tarHeight/rect.Height ();

		//�����׼������

		//�ϱ߽�
		rectnew.top =rect.top ;

		//�±߽�
		rectnew.bottom =rect.top +tarHeight;

		//��߽�
		rectnew.left =rect.left ;

		//�ұ߽�
		rectnew.right =rectnew.left +tarWidth;

		//��ԭ���ο��ڵ�����ӳ�䵽�µľ��ο���
		for(i=rectnew.top ;i<rectnew.bottom ;i++)
		{
			for(j=rectnew.left ;j<rectnew.right ;j++)
			{   

				//����ӳ������
				i_src=rectnew.top +int((i-rectnew.top )/hscale);
				j_src=rectnew.left +int((j-rectnew.left )/wscale);

				//�����Ӧ�����ص����ӳ�����
				lpSrc=(unsigned char *)lpDIBBits + lLineBytes *  i_src + j_src;
				lpDst = (char *)lpNewDIBBits + lLineBytes * i + j;
				*lpDst=*lpSrc;
			}
		}
		//����׼����ľ�����������µ�����
		m_charRectCopy.push_back (rectnew);

	
	}

	//�洢��׼�����µ�rect����
    m_charRect=m_charRectCopy;

	//�������������ݿ�����ͼ�����������
	memcpy(lpDIBBits,lpNewDIBBits,lLineBytes*lHeight);

	//�������
	::GlobalUnlock ((HGLOBAL)hDIB);
}


void Thinning(HDIB hDIB)
{
	// ָ��DIB��ָ��
	LPSTR lpDIB=(LPSTR) ::GlobalLock((HGLOBAL)hDIB);
	
	// ָ��DIB����ָ��
	LPSTR    lpDIBBits;	

	// �ҵ�DIBͼ��������ʼλ��
	lpDIBBits = ::FindDIBBits(lpDIB);	
	
	// ָ��Դͼ���ָ��
	LPSTR	lpSrc;

	//ͼ��ĸ߶ȺͿ��
	LONG lWidth;
	LONG lHeight;

	//��ȡͼ��Ŀ��
	lWidth=::DIBWidth ((char*)lpDIB);

	//��ȡͼ��ĸ߶�
	lHeight=::DIBHeight ((char*)lpDIB);

    //����ÿ�е��ֽ���
    LONG  lLineBytes = (lWidth+3)*4/4;

	//ѭ������
    int i,j;

    //�����洢�����2ֵ����
	BYTE *image = (BYTE*)malloc(lWidth*lHeight*sizeof(BYTE));

	//��2ֵ����ֵ

	for(i=0;i<lHeight;i++)
	{
	    for(j=0;j<lWidth;j++)
		{
	      lpSrc=lpDIBBits+i*lLineBytes+j;
	    
	      if(*lpSrc==0)
	      image[i*lWidth+j]=1;

		  else
         image[i*lWidth+j]=0;
		}
	}

   //���ú�������ϸ��,���ֺ�������ѡ��

   ThinnerRosenfeld(image,lHeight,lWidth);

   //ThinnerHilditch(image,lHeight,lWidth);



   //�������ֵ��ԭͼ����

   for(i=0;i<lHeight;i++)
   {
     for(j=0;j<lWidth;j++)
	 {
	   lpSrc=lpDIBBits+i*lLineBytes+j;

       if(image[i*lWidth+j]==1)
	   *lpSrc=(BYTE)0;

	   else
       *lpSrc=(BYTE)255;
	 }
   
   }


 //����ڴ�
   free(image);
   ::GlobalUnlock ((HGLOBAL)hDIB);

	return;
}

/*****************************************************
* 
*   �������ƣ�
*      Template��
*
*    ������
*	   HDIB    hDIB         ��ͼ��ľ��
*      double  *tem         ��ָ��ģ���ָ��
*      int  tem_w           ��ģ��Ŀ��
*      int  tem_h           ��ģ��ĸ߶�
*      double xishu         ��ģ���ϵ��
*         
*    ���ܣ�
*	   ��ͼ�����ģ�����
*
*    ˵����
*	   Ϊ�����������ģ��Ŀ�Ⱥ͸߶ȶ�ӦΪ����
*******************************************************/
 HDIB Template(HDIB hDIB,double * tem ,int tem_w,int tem_h,double xishu)
{

    //ͳ���м�ֵ
    double sum;

    //ָ��ͼ����ʼλ�õ�ָ��
    BYTE *lpDIB=(BYTE*)::GlobalLock((HGLOBAL) hDIB);

	//ָ��������ʼλ�õ�ָ��
	BYTE *pScrBuff =(BYTE*)::FindDIBBits((char*)lpDIB);
   
	//��ȡͼ�����ɫ��Ϣ
    int numColors=(int) ::DIBNumColors((char *)lpDIB);

    //���ͼ����256ɫ����
     if (numColors!=256) 
	 {   
        //�������
	  	::GlobalUnlock((HGLOBAL) hDIB);

		//����
		return(hDIB);
	 }
    
    //��ָ��ͼ��������ʼλ�õ�ָ�룬��ֵ��ָ�����
    BYTE* oldbuf = pScrBuff;

    //ѭ������
    int i,j,m,n;

	int w, h, dw;

	//��ȡͼ��Ŀ��
	w = (int) ::DIBWidth((char *)lpDIB);
	
	//��ȡͼ��ĸ߶�
	h = (int) ::DIBHeight((char *)lpDIB);
	
	//����ͼ��ÿ�е��ֽ���
	dw = (w+3)/4*4;      
	
	//����һ����ԭͼ���С��ͬ��25ɫ�Ҷ�λͼ
    HDIB newhDIB=NewDIB(w,h,8);  
    
	//ָ���µ�λͼ��ָ��
	BYTE *newlpDIB=(BYTE*)::GlobalLock((HGLOBAL) newhDIB);

	//ָ���µ�λͼ��������ʼλ�õ�ָ�� 
    BYTE *destBuf = (BYTE*)FindDIBBits((char *)newlpDIB);
    
   //��ָ����ͼ��������ʼλ�õ�ָ�룬��ֵ��ָ�����
    BYTE *newbuf=destBuf; 
	
	//��ͼ�����ɨ��
   
	//�� 
    for(i=0;i<h;i++)
    {  
		//��
	   for(j=0;j<w;j++)
	   {   

		   //Ϊͳ�Ʊ�������ʼֵ
	       sum=0;

         //����ͼ���4���߿�����ر���ԭ�ҶȲ���
	     if( j<((tem_w-1)/2) || j>(w-(tem_w+1)/2) || i<((tem_h-1)/2) || i>(h-(tem_h+1)/2) )
	      *(newbuf+i*dw+j)=*(oldbuf+i*dw+j);
		 
         //�������������ؽ���ģ�����
		 else 
         { 

          //���㣨i,j������Ϊģ�������
          for(m=i-((tem_h-1)/2);m<=i+((tem_h-1)/2);m++)
          {
		     for(n=j-((tem_w-1)/2);n<=j+((tem_w-1)/2);n++)
		    
             //���Ե㣨i��j��Ϊ���ģ���ģ���С��ͬ�ķ�Χ�ڵ�������ģ�����λ�õ�ϵ��
			 //������˲����ε���
		     sum+=*(oldbuf+m*dw+n)* tem[(m-i+((tem_h-1)/2))*tem_w+n-j+((tem_w-1)/2)];
		  
		  }
          
		  //����������ܵ�ģ��ϵ��
          sum=(int)sum*xishu;

		  //�������ֵ
		  sum = fabs(sum);

		  //���С��0��ǿ�Ƹ�ֵΪ0
          if(sum<0)     
          sum=0;

		  //�������255��ǿ�Ƹ�ֵΪ255
          if(sum>255)
		  sum=255;

		  //������Ľ���ŵ��µ�λͼ����Ӧλ��
	      *(newbuf+i*dw+j)=sum;
		 }
	   }
	} 
   
	//�������
	::GlobalUnlock((HGLOBAL)hDIB);
    
	//�����µ�λͼ�ľ��
    return(newhDIB);
}
/*****************************************************
* 
*   �������ƣ�
*      Template��
*
*    ������
*	   HDIB    hDIB         ��ͼ��ľ��
*      int  tem_w           ��ģ��Ŀ��
*      int  tem_h           ��ģ��ĸ߶�
*      
*    ���ܣ�
*	   ��ͼ�������ֵ
*
*    ˵����
*	   Ϊ�����������ģ��Ŀ�Ⱥ͸߶ȶ�ӦΪ����
*******************************************************/

HDIB MidFilter(HDIB hDIB,int tem_w,int tem_h)
{

    //ͳ���м�ֵ
    double mid;

	BYTE *temp=(BYTE*)malloc(tem_w*tem_h*sizeof(BYTE));

    //ָ��ͼ����ʼλ�õ�ָ��
    BYTE *lpDIB=(BYTE*)::GlobalLock((HGLOBAL) hDIB);

	//ָ��������ʼλ�õ�ָ��
	BYTE *pScrBuff =(BYTE*)::FindDIBBits((char*)lpDIB);
   
	//��ȡͼ�����ɫ��Ϣ
    int numColors=(int) ::DIBNumColors((char *)lpDIB);

    //���ͼ����256ɫ����
     if (numColors!=256) 
	 {   
        //�������
	  	::GlobalUnlock((HGLOBAL) hDIB);

		//����
		return(hDIB);
	 }
    
    //��ָ��ͼ��������ʼλ�õ�ָ�룬��ֵ��ָ�����
    BYTE* oldbuf = pScrBuff;

    //ѭ������
    int i,j,m,n;

	int w, h, dw;

	//��ȡͼ��Ŀ��
	w = (int) ::DIBWidth((char *)lpDIB);
	
	//��ȡͼ��ĸ߶�
	h = (int) ::DIBHeight((char *)lpDIB);
	
	//����ͼ��ÿ�е��ֽ���
	dw = (w+3)/4*4;      
	
	//����һ����ԭͼ���С��ͬ��25ɫ�Ҷ�λͼ
    HDIB newhDIB=NewDIB(w,h,8);  
    
	//ָ���µ�λͼ��ָ��
	BYTE *newlpDIB=(BYTE*)::GlobalLock((HGLOBAL) newhDIB);

	//ָ���µ�λͼ��������ʼλ�õ�ָ�� 
    BYTE *destBuf = (BYTE*)FindDIBBits((char *)newlpDIB);
    
   //��ָ����ͼ��������ʼλ�õ�ָ�룬��ֵ��ָ�����
    BYTE *newbuf=destBuf; 
	
	//��ͼ�����ɨ��
   
	//�� 
    for(i=0;i<h;i++)
    {  
		//��
	   for(j=0;j<w;j++)
	   {   

		   //Ϊͳ�Ʊ�������ʼֵ
	       

         //����ͼ���4���߿�����ر���ԭ�ҶȲ���
	     if( j<((tem_w-1)/2) || j>(w-(tem_w+1)/2) || i<((tem_h-1)/2) || i>(h-(tem_h+1)/2) )
	      *(newbuf+i*dw+j)=*(oldbuf+i*dw+j);
		 
         //�������������ؽ���ģ�����
		 else 
         { 

          //���㣨i,j������Ϊģ�������
          for(m=i-((tem_h-1)/2);m<=i+((tem_h-1)/2);m++)
          {
		     for(n=j-((tem_w-1)/2);n<=j+((tem_w-1)/2);n++)
		    
             //���Ե㣨i��j��Ϊ���ģ���ģ���С��ͬ�ķ�Χ�ڵ����ش��ݵ�ģ�������
		     temp[(m-i+((tem_h-1)/2))*tem_w+n-j+((tem_w-1)/2)]=*(oldbuf+m*dw+n);
		  
		  }
          
		 //�������ݷ�������ֵ
           for(m=0;m<tem_w*tem_h-1;m++)
           {
		   
		      for(n=0;n<tem_w*tem_h-m-1;n++)
			  {
			    if(temp[n]>temp[n+1]) 
			    mid=temp[n];
                temp[n]=temp[n+1];
			    temp[n+1]=mid;
			  }
		   
		   } 

           //������Ľ���ŵ��µ�λͼ����Ӧλ��
	      *(newbuf+i*dw+j)=temp[(tem_w*tem_h-1)/2];
		 }
	   }
	} 
   
	//�������
	::GlobalUnlock((HGLOBAL)hDIB);
    
	//�����µ�λͼ�ľ��
    return(newhDIB);
}



/*************************************************************************
 *
 * �������ƣ�
 *   Equalize()
 *
 * ����:
 *   HDIB hDIB
 *
 *
 * ˵��:
 *   �ú���������ͼ�����ֱ��ͼ���⡣
 *
 ************************************************************************/
void Equalize(HDIB hDIB)
{
	BYTE* lpDIB=(BYTE*)::GlobalLock ((HGLOBAL)hDIB);
	BYTE* lpDIBBits=(BYTE*)::FindDIBBits((char*)lpDIB);
	LONG lHeight=::DIBHeight ((char*)lpDIB);
	LONG lWidth=::DIBWidth ((char*)lpDIB);
	// ָ��Դͼ���ָ��
	unsigned char*	lpSrc;
	
	// ��ʱ����
	LONG	lTemp;
	
	// ѭ������
	LONG	i;
	LONG	j;
	
	// �Ҷ�ӳ���
	BYTE	bMap[256];
	
	// �Ҷ�ӳ���
	LONG	lCount[256];
	
	// ͼ��ÿ�е��ֽ���
	LONG	lLineBytes;
	
	// ����ͼ��ÿ�е��ֽ���
	lLineBytes = WIDTHBYTES(lWidth * 8);
	
	// ���ü���Ϊ0
	for (i = 0; i < 256; i ++)
	{
		// ����
		lCount[i] = 0;
	}
	
	// ��������Ҷ�ֵ�ļ���
	for (i = 0; i < lHeight; i ++)
	{
		for (j = 0; j < lWidth; j ++)
		{
			lpSrc = (unsigned char *)lpDIBBits + lLineBytes * i + j;
			
			// ������1
			lCount[*(lpSrc)]++;
		}
	}
	
	// ����Ҷ�ӳ���
	for (i = 0; i < 256; i++)
	{
		// ��ʼΪ0
		lTemp = 0;
		
		for (j = 0; j <= i ; j++)
		{
			lTemp += lCount[j];
		}
		
		// �����Ӧ���»Ҷ�ֵ
		bMap[i] = (BYTE) (lTemp * 255 / lHeight / lWidth);
	}
	
	// ÿ��
	for(i = 0; i < lHeight; i++)
	{
		// ÿ��
		for(j = 0; j < lWidth; j++)
		{
			// ָ��DIB��i�У���j�����ص�ָ��
			lpSrc = (unsigned char*)lpDIBBits + lLineBytes * (lHeight - 1 - i) + j;
			
			// �����µĻҶ�ֵ
			*lpSrc = bMap[*lpSrc];
		}
	}
	
	::GlobalUnlock ((HGLOBAL)hDIB);
}

