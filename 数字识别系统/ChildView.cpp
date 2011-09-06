// ChildView.cpp : implementation of the CChildView class
//
#include "stdafx.h"
#include "DigitRec.h"
#include "ChildView.h"
#include "INPUT1.h"
#include "mydiblib.h"
#include "Bp.h"
#include "DBpParamater.h"
#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif
void ThiningDIB(LPSTR lpDIBBits, LONG lWidth, LONG lHeight);
/////////////////////////////////////////////////////////////////////////////
// CChildView

CChildView::CChildView()
{
	fileloaded=false;
	gyhinfoinput=false;
	gyhfinished=false;
	m_hDIB=NULL;
}

CChildView::~CChildView()
{
}

BEGIN_MESSAGE_MAP(CChildView,CWnd )
	//{{AFX_MSG_MAP(CChildView)
	ON_WM_PAINT()
	ON_COMMAND(IDmy_FILE_OPEN_BMP, OnFileOpenBmp)
	ON_COMMAND(IDmy_FILE_SAVE_BMP, OnFileSaveBmp)
	ON_COMMAND(IDmy_IMGPRC_SHRINK_ALIGN, OnImgprcShrinkAlign)
	ON_COMMAND(IDmy_IMGPRC_ALL, OnImgprcAll)
	ON_COMMAND(IDmy_IMGPRC_256ToGray, OnIMGPRC256ToGray)
	ON_COMMAND(IDmy_IMGPRC_DIVIDE, OnImgprcDivide)
	ON_COMMAND(IDmy_IMGPRC_TO_DIB_AND_SAVE, OnImgprcToDibAndSave)
	ON_COMMAND(IDmy_IMGPRC_REMOVE_NOISE, OnImgprcRemoveNoise)
	ON_COMMAND(IDmy_IMGPRC_STANDARIZE, OnImgprcStandarize)
	ON_COMMAND(IDmy_IMGPRC_THINNING, OnImgprcThinning)
	ON_COMMAND(IDmy_IMGPRC_ADJUST_SLOPE, OnImgprcAdjustSlope)
	ON_COMMAND(IDmy_IMGPRC_GrayToWhiteBlack, OnIMGPRCGrayToWhiteBlack)
	ON_COMMAND(IDmy_IMGPRC_SHARP, OnImgprcSharp)
	ON_COMMAND(IDmy_FILE_RE_LOAD_BMP, OnFileReLoadBmp)
	ON_COMMAND(ID_INPUT1, OnInputGuiyihuaInfo)
	ON_COMMAND(IDmy_BPNET_TRAIN, OnBpnetTrain)
	ON_COMMAND(IDmy_BPNET_RECOGNIZE, OnBpnetRecognize)
	ON_COMMAND(ID_aver, Onaver)
	ON_COMMAND(ID_Gass, OnGass)
	ON_COMMAND(ID_Mid, OnMid)
	ON_COMMAND(IDmy_IMGPRC_EQUALIZE, OnImgprcEqualize)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CChildView message handlers

BOOL CChildView::PreCreateWindow(CREATESTRUCT& cs) 
{
	if (!CWnd::PreCreateWindow(cs))
		return FALSE;

	cs.dwExStyle |= WS_EX_CLIENTEDGE;
	cs.style &= ~WS_BORDER;
	cs.lpszClass = AfxRegisterWndClass(CS_HREDRAW|CS_VREDRAW|CS_DBLCLKS, 
		::LoadCursor(NULL, IDC_ARROW), HBRUSH(COLOR_WINDOW+1), NULL);

	return TRUE;
}

void CChildView::OnPaint() 
{
	CPaintDC dc(this); // device context for painting
	OnDraw(&dc);
	// Do not call CWnd::OnPaint() for painting messages
}

//��256ɫλͼ�ļ�
void CChildView::OnFileOpenBmp() 
{
	//����һ�����ļ��Ի��򣬲������������ļ�·��
	static char BASED_CODE szFilter[] = "256ɫλͼ�ļ�(*.bmp)|";
	CFileDialog dlg(TRUE,NULL,NULL,OFN_HIDEREADONLY|OFN_OVERWRITEPROMPT,szFilter,NULL);
    if(dlg.DoModal() == IDOK)
	   strPathName = dlg.GetPathName();
	else return;
	//����һ���ļ�����
   	CFile file;
	//��ֻ��ģʽ���ļ�
	file.Open (strPathName,CFile::modeRead);
	//��ȡ�ļ���HDIB�����. ע��:��ʱֻ�Ƕ�ȡλͼ�ļ����ļ�ͷ֮��Ĳ���,�����ļ�ͷ
	m_hDIB=::ReadDIBFile (file);
	//HDIB���: ����һ��洢λͼ���ݵ��ڴ�����ĵ�ַ
	//HDIB�������:λͼ��Ϣͷ����ɫ��(����еĻ�)��DIBͼ������
	//�ر��ļ�
	file.Close ();
	//ָ��DIB��ָ��(ָ��λͼ��Ϣͷ)
	BYTE* lpDIB=(BYTE*)::GlobalLock ((HGLOBAL)m_hDIB);
	// ��ȡDIB����ɫ���е���ɫ��Ŀ
	WORD wNumColors;	
	wNumColors = ::DIBNumColors((char*)lpDIB);	
	// �ж��Ƿ���256ɫλͼ
	if (wNumColors != 256)
	{
		// ��ʾ�û�
		MessageBox("��256ɫλͼ��", "ϵͳ��ʾ" , MB_ICONINFORMATION | MB_OK);
		// �������
		::GlobalUnlock((HGLOBAL)m_hDIB);
		// ����
		return;
	}
	//����Ļ����ʾλͼ
	CDC* pDC=GetDC();
	DisplayDIB(pDC,m_hDIB);	
	//����λͼ�ļ��Ƿ��Ѽ��صı�־
	fileloaded=true;
    //gyhinfoinput=false;          //2004.4.26�޸�
	gyhfinished=false;
}

//ȡ��һ�и��ģ����¼���λͼ�ļ�
void CChildView::OnFileReLoadBmp() 
{
	//�ж�λͼ�ļ��Ƿ��Ѽ��ء������δ���أ��򵯳��ļ��򿪶Ի���
	if(fileloaded==false)
	{
		OnFileOpenBmp();
		if(fileloaded==false)
			return;
	}
	//����һ���ļ�����
   	CFile file;
	//��ֻ��ģʽ���ļ�
	file.Open (strPathName,CFile::modeReadWrite);
	m_hDIB=::ReadDIBFile (file);
	//�ر��ļ�
	file.Close ();
	//����Ļ����ʾλͼ
	CDC* pDC=GetDC();
	DisplayDIB(pDC,m_hDIB);		
}


void CChildView::OnFileSaveBmp() 
{
	//����һ�������ļ��Ի��򣬲������������ļ�·��
	static char BASED_CODE szFilter[] = "256ɫλͼ�ļ�(*.bmp)|";
	CFileDialog dlg(FALSE,NULL,NULL,OFN_HIDEREADONLY|OFN_OVERWRITEPROMPT,szFilter,NULL);
    if(dlg.DoModal() == IDOK)
	   strPathNameSave = dlg.GetPathName();
	else return;
	//���ļ��������.bmp��׺
	//strPathNameSave+=".bmp";
	//�Զ�дģʽ��һ���ļ�������ļ������ڣ��򴴽�֮
   	CFile file(strPathNameSave, CFile::modeReadWrite|CFile::modeCreate);
	::SaveDIB (m_hDIB,file);
	//�ر��ļ�
	file.Close ();	
}

//һ����Ԥ����
void CChildView::OnImgprcAll() 
{
	if(fileloaded==false)
	{
		if(::AfxMessageBox ("���ȴ�һ��ͼ���ļ��ٽ��д˲�����",MB_YESNO|MB_ICONSTOP)==IDNO)
		   return;
	}
	//���ļ�
	OnFileReLoadBmp();
	//�ж��û��Ƿ��������һ���߶ȺͿ����Ϣ
	if(gyhinfoinput==false) OnInputGuiyihuaInfo();
	//��256ɫͼת��Ϊ�Ҷ�ͼ
	OnIMGPRC256ToGray();
	//���Ҷ�ͼ��ֵ��
	OnIMGPRCGrayToWhiteBlack();
	//�ݶ���
	//OnImgprcSharp();
	//ȥ����ɢ�ӵ�����
	OnImgprcRemoveNoise();
	//���������ַ���������б
	OnImgprcAdjustSlope();
	//�ָ�����ʶ
	OnImgprcDivide();
	//���ָ��������ַ����߱�׼�����Ա�����һ����BP������������
	OnImgprcStandarize();
	ConvertGrayToWhiteBlack(m_hDIB);
	//�������������ַ�
	OnImgprcShrinkAlign();
	//�ֱ𱣴���Щ�Ѿ������ָ��׼��ĵ����������ַ���bmp�ļ����Ա��������ʹ��
	//OnImgprcToDibAndSave();
	//OnPreprocThin();	
}

//ͼ��Ԥ�����1������256ɫͼ��ת��Ϊ�Ҷ�ͼ��
void CChildView::OnIMGPRC256ToGray() 
{	
	Convert256toGray(m_hDIB);	
	//����Ļ����ʾλͼ
	CDC* pDC=GetDC();
	DisplayDIB(pDC,m_hDIB);	
}

//ͼ��Ԥ�����2�������Ҷ�ͼ��ֵ��
void CChildView::OnIMGPRCGrayToWhiteBlack()
{
	ConvertGrayToWhiteBlack(m_hDIB);
	//����Ļ����ʾλͼ
	CDC* pDC=GetDC();
	DisplayDIB(pDC,m_hDIB);	
}

//ͼ��Ԥ�����3�����ݶ���
void CChildView::OnImgprcSharp() 
{
	GradientSharp(m_hDIB);
	//����Ļ����ʾλͼ
	CDC* pDC=GetDC();
	DisplayDIB(pDC,m_hDIB);		
}

//ͼ��Ԥ�����4����ȥ��ɢ�ӵ�����
void CChildView::OnImgprcRemoveNoise() 
{
	RemoveScatterNoise(m_hDIB);
	//����Ļ����ʾλͼ
	CDC* pDC=GetDC();
	DisplayDIB(pDC,m_hDIB);	
}

//ͼ��Ԥ�����5������б�ȵ���
void CChildView::OnImgprcAdjustSlope() 
{
    SlopeAdjust(m_hDIB);
	//����Ļ����ʾλͼ
	CDC* pDC=GetDC();
	DisplayDIB(pDC,m_hDIB);	
}

//ͼ��Ԥ�����6�����ָ���ڷָ�������ַ����滭���Ա�ʶ
void CChildView::OnImgprcDivide() 
{
	m_charRect=CharSegment(m_hDIB);
	//����Ļ����ʾλͼ
	CDC* pDC=GetDC();
	DisplayDIB(pDC,m_hDIB);	
	DrawFrame(pDC,m_hDIB,m_charRect,2,RGB(20,60,200));
}

//ͼ��Ԥ�����7������׼��һ��
//���ָ�����ĸ�����ͬ���ߵ������ַ�����ͳһ
void CChildView::OnImgprcStandarize() 
{
	StdDIBbyRect(m_hDIB,w_sample,h_sample);
	//����Ļ����ʾλͼ
	CDC* pDC=GetDC();
	DisplayDIB(pDC,m_hDIB);	
	DrawFrame(pDC,m_hDIB,m_charRect,2,RGB(21,255,25));
	gyhfinished=true;
}

//ͼ��Ԥ�����8�������������Ѿ��ָ���ϵ������ַ������γ��µ�λͼ���
void CChildView::OnImgprcShrinkAlign() 
{
	m_hDIB=AutoAlign(m_hDIB);
	//����Ļ����ʾλͼ
	CDC* pDC=GetDC();
	DisplayDIB(pDC,m_hDIB);	
	DrawFrame(pDC,m_hDIB,m_charRect,1,RGB(252,115,27));
}

//ͼ��Ԥ�����9���������ձ�׼������ַ�ͼ���Ϊ����������HDIB���棬����Ϊ.bmp�ļ�
void CChildView::OnImgprcToDibAndSave() 
{
	unsigned char* lpSrc;
	int w,h;
	w=m_charRect.front ().Width() ;
	h=m_charRect.front ().Height() ;
	m_dibRect.clear ();
	m_dibRectCopy.clear ();
	int i_src,j_src;
	int i,j;
	int counts=0;
	CRect rect,rectnew;
	BYTE* lpDIB=(BYTE*)::GlobalLock ((HGLOBAL)m_hDIB);
	BYTE* lpDIBBits=(BYTE*)::FindDIBBits ((char*)lpDIB);
	BYTE* lpNewDIBBits;
	BYTE* lpDst;
	LONG lLineBytes=(digicount*w+3)/4*4;
	LONG lLineBytesnew =(w+3)/4*4;
	HDIB hDIB=NULL;
	while(!m_charRect.empty ())
	{
		hDIB=::NewDIB (w,h,8);
		lpDIB=(BYTE*) ::GlobalLock((HGLOBAL)hDIB);	
		lpNewDIBBits = (BYTE*)::FindDIBBits((char*)lpDIB);
		lpDst=(BYTE*)lpNewDIBBits;
		memset(lpDst,(BYTE)255,lLineBytesnew * h);		
		rect=m_charRect.front ();
		m_charRect.pop_front ();
		for(i=0;i<h;i++)
			for(j=0;j<w;j++)
			{
				i_src=rect.top + i;
				j_src=j+counts*w;
				lpSrc=(BYTE *)lpDIBBits + lLineBytes *  i_src + j_src;
				lpDst=(BYTE *)lpNewDIBBits + lLineBytesnew * i + j;
				*lpDst=*lpSrc;
			}
		::GlobalUnlock (hDIB);
		m_dibRect.push_back (hDIB);
		counts++;
	}
	m_charRect=m_charRectCopy;
	m_dibRectCopy=m_dibRect;
	//���Ϊ.bmp�ļ�
	CString str;
	counts=1;
	while(!m_dibRect.empty ())
	{
		str.Format ("part%d.bmp",counts);
		//str=strPath+"\\"+str;
   		CFile file(str, CFile::modeReadWrite|CFile::modeCreate);
		hDIB=m_dibRect.front ();
		::SaveDIB (hDIB,file);
		m_dibRect.pop_front ();
		file.Close ();	
		counts++;
	}
	m_dibRect=m_dibRectCopy;
}

void CChildView::OnImgprcThinning() 
{
	 Thinning(m_hDIB);	
	//����Ļ����ʾλͼ
	CDC* pDC=GetDC();
	DisplayDIB(pDC,m_hDIB);	
}



void CChildView::OnInputGuiyihuaInfo() 
{
	CINPUT1 input;
	input.w =8;
	input.h =16;
	if(input.DoModal ()!=IDOK) return;
	w_sample=input.w;
	h_sample=input.h;
	gyhinfoinput=true;
}

void CChildView::OnBpnetTrain() 
{
	OnImgprcAll();
	//�ж��Ƿ񾭹��˹�һ���Ĵ���
	if(gyhfinished==false)
	{
		//���û�н�����ʾ���󲢷���
		::MessageBox(NULL,"û�н��й�һ��Ԥ����",NULL,MB_ICONSTOP);
		return;
	}
	
	//����BP����ѵ�������Ի���
	
	CDBpParamater BpPa;
	
	//��ʼ������
	BpPa.m_a=0; // ��ز���
	BpPa.m_eta=0.015; // ѵ������
	BpPa.m_ex=0.001; // ��С�������
	BpPa.m_hn=10; // �����������
	
	// ��ʾ�Ի���
	if(BpPa.DoModal()!=IDOK)
	{
		//����
		return;
	}
	//�û���ò�����Ϣ
	
	//���ϵ��
	double  momentum=BpPa.m_a; 
	//��С�������
	double  min_ex=BpPa.m_ex; 
	//��������Ŀ
	int  n_hidden=BpPa.m_hn; 
	//ѵ������
	double eta=BpPa.m_eta;
	
	
	
	//���ָ��DIB��ָ��
	BYTE *lpDIB=(BYTE*)::GlobalLock((HGLOBAL) m_hDIB);
	
	//���ָ��DIB���ص�ָ�룬��ָ�����ص���ʼλ��
	BYTE *lpDIBBits =(BYTE*)::FindDIBBits((char *)lpDIB);
	
	//�����ɫ��Ϣ
	int numColors=(int) ::DIBNumColors((char *)lpDIB);
	//���ǻҶ�ͼ����
    if (numColors!=256) 
	{
		::GlobalUnlock((HGLOBAL) m_hDIB);
		::MessageBox(NULL,"ֻ�ܴ���Ҷ�ͼ��",NULL,MB_ICONSTOP);
		return;
	}
	
	//��ȡͼ��Ŀ��
    LONG lWidth = (LONG) ::DIBWidth((char *)lpDIB); 
	
	//��ȡͼ��ĸ߶�
	LONG lHeight = (LONG) ::DIBHeight((char *)lpDIB);
	
	//����ͼ��ÿ�е��ֽ���
	LONG lLineByte = (lWidth+3)/4*4; 
	
	//��һ���Ŀ��
	LONG lSwidth = w_sample;
	
	//��һ���ĸ߶�
	LONG LSheight = h_sample;
	
	//ָ����������������������ָ��  
	double **data_in;
	//�������ѵ����������ȡ��������
	data_in = code ( lpDIBBits, digicount,  lLineByte, lSwidth, LSheight);
	
	//��������������Ŀ
	
	int n_in = LSheight*lSwidth;
	
	double out[][4]={     
		0.1,0.1,0.1,0.1,
		0.1,0.1,0.1,0.9,
		0.1,0.1,0.9,0.1,
		0.1,0.1,0.9,0.9,
		0.1,0.9,0.1,0.1,
		0.1,0.9,0.1,0.9,
		0.1,0.9,0.9,0.1,
		0.1,0.9,0.9,0.9,
		0.9,0.1,0.1,0.1,
		0.9,0.1,0.1,0.9};
	
	
	
	double **data_out;
	
	data_out = alloc_2d_dbl(digicount,4);
	
	for(int i=0;i<digicount;i++)
	{
		for(int j=0;j<4;j++)
			data_out[i][j]=out[i%10][j];
		
	}
	
	BpTrain( data_in, data_out, n_in,n_hidden,min_ex,momentum,eta,digicount);
	
	::GlobalUnlock(m_hDIB);
	
	CDC* pDC=GetDC();
	DisplayDIB(pDC,m_hDIB);
	
}



void CChildView::OnBpnetRecognize() 
{
	// TODO: Add your command handler code here
	OnImgprcAll();
	//�ж��Ƿ񾭹��˹�һ���Ĵ���
	if(gyhfinished==false)
	{
		//���û�н�����ʾ���󲢷���
		::MessageBox(NULL,"û�н��й�һ��Ԥ����",NULL,MB_ICONSTOP);
		return;
	}
	//���ָ��DIB��ָ��
	BYTE *lpDIB=(BYTE*)::GlobalLock((HGLOBAL) m_hDIB);
	
	//���ָ��DIB���ص�ָ�룬��ָ�����ص���ʼλ��
	BYTE *lpDIBBits =(BYTE*)::FindDIBBits((char *)lpDIB);
	
	//�����ɫ��Ϣ
	int numColors=(int) ::DIBNumColors((char *)lpDIB);
	//���ǻҶ�ͼ����
    if (numColors!=256) 
	{
		::GlobalUnlock((HGLOBAL) m_hDIB);
		::MessageBox(NULL,"ֻ�ܴ���256ɫͼ��",NULL,MB_ICONSTOP);
		return;
	}
	
	//��ȡͼ��Ŀ��
    LONG lWidth = (LONG) ::DIBWidth((char *)lpDIB); 
	
	//��ȡͼ��ĸ߶�
	LONG lHeight = (LONG) ::DIBHeight((char *)lpDIB);
	
	//����ͼ��ÿ�е��ֽ���
	LONG lLineByte = (lWidth+3)/4*4; 
	
	//��һ���Ŀ��
	LONG lSwidth = w_sample;
	
	//��һ���ĸ߶�
	LONG LSheight = h_sample;
	
	// ��ȡ�����Ϣ
	int n[3];
	if(r_num(n,"num")==false)
		return;
	//������������Ŀ
	int  n_in=n[0];
	//�����������Ŀ
	int  n_hidden=n[1];
	//������������Ŀ
	int  n_out=n[2];  
	
	//�жϴ�ʶ�������Ĺ�һ����Ϣ�Ƿ���ѵ��ʱ��ͬ
	if(n_in!=lSwidth*LSheight)
	{
		//�������ͬ��ʾ���󲢷���
		::MessageBox(NULL,"��һ���ߴ�����һ��ѵ��ʱ��һ��",NULL,MB_ICONSTOP);
		return;
	}
	
	//ָ����������������������ָ��  
	double **data_in;
	//�������ѵ����������ȡ��������
	data_in = code ( lpDIBBits, digicount,  lLineByte, lSwidth, LSheight);
	
	//������ȡ��������������ʶ��
	CodeRecognize(data_in, digicount,n_in,n_hidden,n_out);
	::GlobalUnlock(m_hDIB);
	
	CDC* pDC=GetDC();
	DisplayDIB(pDC,m_hDIB);
	
}

void CChildView::OnDraw(CDC *pDC)
{
	if(m_hDIB!=NULL) 
		DisplayDIB(pDC,m_hDIB);
}


void CChildView::Onaver() 
{
	// TODO: Add your command handler code here
//�趨ģ�����
	double tem[9]={1,1,1,
		           1,1,1,
				   1,1,1};

    //�趨ģ��ϵ��
    double  xishu = 0.111111;   

    //����ģ�����
	m_hDIB =Template(m_hDIB,tem ,3,3, xishu);

	//��ʾͼ��
	CDC* pDC=GetDC();
	DisplayDIB(pDC,m_hDIB);
	
}

void CChildView::OnGass() 
{
	// TODO: Add your command handler code here
   
	//�趨ģ�����
	double tem[9]={1,2,1,
		           2,4,2,
				   1,2,1};

    //�趨ģ��ϵ��
    double  xishu = 0.0625;   

    //����ģ�����
	m_hDIB =Template(m_hDIB,tem ,3,3, xishu);

	//��ʾͼ��
	CDC* pDC=GetDC();
	DisplayDIB(pDC,m_hDIB);
}

void CChildView::OnMid() 
{
	// TODO: Add your command handler code here
	//������ֵ�˲�
	m_hDIB =MidFilter(m_hDIB,3,3);

	//��ʾͼ��
	CDC* pDC=GetDC();
	DisplayDIB(pDC,m_hDIB);
}

void CChildView::OnImgprcEqualize() 
{
	Equalize(m_hDIB);

	//��ʾͼ��
	CDC* pDC=GetDC();
	DisplayDIB(pDC,m_hDIB);
}
