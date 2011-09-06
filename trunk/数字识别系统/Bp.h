
#include <stdio.h>
#include <math.h> 
#include <time.h>
#include <stdlib.h>
#define BIGRND 32767

double drnd();
double dpn1();
double squash(double x);
double *alloc_1d_dbl(int n);
double *alloc_1d_dbl(int n);
double **alloc_2d_dbl(int m, int n);
void bpnn_initialize(int seed);
void bpnn_randomize_weights(double **w, int m, int n);
void bpnn_zero_weights(double **w, int m, int n);
void bpnn_layerforward(double *l1, double *l2, double **conn, int n1, int n2);
void bpnn_output_error(double *delta, double *target, double *output, int nj);
void bpnn_hidden_error(double* delta_h, int nh, double *delta_o, int no, double **who, double *hidden);
void bpnn_adjust_weights(double *delta, int ndelta, double *ly, int nly, double** w, double **oldw, double eta, double momentum);
void w_weight(double **w,int n1,int n2,char*name);
bool r_weight(double **w,int n1,int n2,char *name);
void w_num(int n1,int n2,int n3,char*name);
bool r_num(int *n,char *name);

void code(BYTE*image ,int *p,int w,int h,int dw);
void BpTrain(HDIB hDIB,int n_hidden,double min_ex,double momentum,double eta ,int width,int height);
void CodeRecognize(HDIB hDIB,int width ,int height ,int n_in ,int n_hidden,int n_out);


/*** ����0��1��˫��������� ***/
double drnd()
{
	return ((double) rand() / (double) BIGRND);
}

/*** ����-1.0��1.0֮���˫��������� ***/
double dpn1()
{
	return ((drnd() * 2.0) - 1.0);
}

double squash(double x)
{
	return (1.0 / (1.0 + exp(-x)));
}
/*** ����1ά˫����ʵ������ ***/

double *alloc_1d_dbl(int n)
{
	double *new1;
	
	new1 = (double *) malloc ((unsigned) (n * sizeof (double)));
	if (new1 == NULL) {
		printf("ALLOC_1D_DBL: Couldn't allocate array of doubles\n");
		return (NULL);
	}
	return (new1);
}

/*** ����2ά˫����ʵ������ ***/

double **alloc_2d_dbl(int m, int n)
{
	int i;
	double **new1;
	
	new1 = (double **) malloc ((unsigned) (m * sizeof (double *)));
	if (new1 == NULL) {
		//	printf("ALLOC_2D_DBL: Couldn't allocate array of dbl ptrs\n");
		return (NULL);
	}
	
	for (i = 0; i < m; i++) {
		new1[i] = alloc_1d_dbl(n);
	}
	
	return (new1);
}

/*** ������������� ***/
void bpnn_initialize(int seed)
{
	//printf("Random number generator seed: %d\n", seed);
	srand(seed);
}

/*** �����ʼ��Ȩֵ ***/
void bpnn_randomize_weights(double **w, int m, int n)
{
	int i, j;
	
	for (i = 0; i <= m; i++) {
		for (j = 0; j <= n; j++) {
			
			w[i][j] = dpn1();
		}
	}
}
/*** 0��ʼ��Ȩֵ ***/
void bpnn_zero_weights(double **w, int m, int n)
{
	int i, j;
	
	for (i = 0; i <= m; i++) {
		for (j = 0; j <= n; j++) {
			w[i][j] = 0.0;
		}
	}
}

/*********ǰ����*********/
void bpnn_layerforward(double *l1, double *l2, double **conn, int n1, int n2)
{
	double sum;
	int j, k;
	
	/*** ������ֵ ***/
	l1[0] = 1.0;
	
	/*** ���ڵڶ����ÿ����Ԫ ***/
	for (j = 1; j <= n2; j++) {
		
		/*** ��������ļ�Ȩ�ܺ� ***/
		sum = 0.0;
		for (k = 0; k <= n1; k++) {
			sum += conn[k][j] * l1[k];
		}
		l2[j] = squash(sum);
	}
}

/* ������ */

void bpnn_output_error(double *delta, double *target, double *output, int nj)
{
	int j;
	double o, t, errsum;
	
	errsum = 0.0;
	for (j = 1; j <= nj; j++) {
		o = output[j];
		t = target[j];
		delta[j] = o * (1.0 - o) * (t - o);
		
	}
	
}

/* ��������� */

void bpnn_hidden_error(double* delta_h, int nh, double *delta_o, int no, double **who, double *hidden)
{
	int j, k;
	double h, sum, errsum;
	
	errsum = 0.0;
	for (j = 1; j <= nh; j++) {
		h = hidden[j];
		sum = 0.0;
		for (k = 1; k <= no; k++) {
			sum += delta_o[k] * who[j][k];
		}
		delta_h[j] = h * (1.0 - h) * sum;
		
	}
	
}

/* ����Ȩֵ */
void bpnn_adjust_weights(double *delta, int ndelta, double *ly, int nly, double** w, double **oldw, double eta, double momentum)
{
	double new_dw;
	int k, j;
	
	ly[0] = 1.0;
	for (j = 1; j <= ndelta; j++) {
		for (k = 0; k <= nly; k++) {
			new_dw = ((eta * delta[j] * ly[k]) + (momentum * oldw[k][j]));
			w[k][j] += new_dw;
			oldw[k][j] = new_dw;
		}
	}
}
/*******����Ȩֵ**********/
void w_weight(double **w,int n1,int n2,char*name)
{
	int i,j;
	double *buffer;
	FILE *fp;
	fp=fopen(name,"wb+");
	buffer=(double*)malloc((n1+1)*(n2+1)*sizeof(double));
	for(i=0;i<=n1;i++)
	{
		for(j=0;j<=n2;j++)
			buffer[i*(n2+1)+j]=w[i][j];
	}
	fwrite((char*)buffer,sizeof(double),(n1+1)*(n2+1),fp);
	fclose(fp);
	free(buffer);
}



/************��ȡȨֵ*************/
bool  r_weight(double **w,int n1,int n2,char *name)
{
	int i,j;
	double *buffer;
	FILE *fp;
	if((fp=fopen(name,"rb"))==NULL)
	{
		::MessageBox(NULL,"�޷���ȡȨֵ��Ϣ",NULL,MB_ICONSTOP);
		return (false);
	}
	buffer=(double*)malloc((n1+1)*(n2+1)*sizeof(double));
	fread((char*)buffer,sizeof(double),(n1+1)*(n2+1),fp);
	
	for(i=0;i<=n1;i++)
	{
		for(j=0;j<=n2;j++)
			w[i][j]=buffer[i*(n2+1)+j];
	}
	fclose(fp);
	free(buffer);
	return(true);
}

/*****������������Ŀ******/
void w_num(int n1,int n2,int n3,char*name)
{
	FILE *fp;
	fp=fopen(name,"wb+");
	int *buffer;
	buffer=(int*)malloc(3*sizeof(int));
	buffer[0]=n1;
	buffer[1]=n2;
	buffer[2]=n3;
	fwrite((char*)buffer,sizeof(int),3,fp);
	fclose(fp);
	free(buffer);
}

/********��ȡ��������Ŀ*********/

bool r_num(int *n,char *name)
{
	int *buffer;
	FILE *fp;
	buffer=(int *)malloc(3*sizeof(int));
	if((fp=fopen(name,"rb"))==NULL)
	{
		::MessageBox(NULL,"������",NULL,MB_ICONSTOP);
		return (false);
	}
	fread((char*)buffer,sizeof(int),3,fp);
	n[0]=buffer[0];
	n[1]=buffer[1];
	n[2]=buffer[2];
	fclose(fp);
	free(buffer);
	return(true);
}
/********************************************************
* �������� VerticalCode()
*
* ������
*   BYTE* lpDIBBits   ��ָ������ͼ���������ʵλ�õ�ָ�� 
*   int  num          ��ͼƬ�������ĸ���
*   LONG lLineByte    ������ͼƬÿ�е��ֽ���
*   LONG lSwidth      ��Ԥ����ʱ��һ���Ŀ��
*   LONG lSheight     ��Ԥ����ʱ��һ���ĳ���
*
* ����ֵ��
*   double**           ��������������
*
*  �������� ��
*      ��������������ȡ����������������ѹ�һ��������
*	   ˮƽ����ֱ�����ͳ��������Ϊ������ȡ����
***************************************************************/

double** VerticalCode(BYTE* lpDIBBits,int num, LONG lLineByte,LONG lSwidth,LONG lSheight)
{   
   //ѭ������
    int i,j,k;
    BYTE* lpSrc; 
    
	//ͳ�Ʊ���
	int sum;

    //  �����������������Ķ�ά����
   double **data;
   
   // Ϊ������������ά�洢�ռ�
   data = alloc_2d_dbl(num,lSwidth+lSheight);
 
   // ����һ����������ÿ��������Ϊһ����������ȡ����

   //�������ɨ��
   for(k=0;k<num;k++)  
   { 
     //ͳ��ÿ�е����ص����
      for(i=0;i<lSheight;i++)
	  {    
        //��ͳ�Ʊ�����ʼ��
	 	  sum=0;

          //��ÿ����������ɨ��
          for(j=k*lSwidth;j<(k+1)*lSwidth;j++)
		  {
            // ָ��ͼ���i�е�j�и����ص�ָ��
            lpSrc = lpDIBBits + i*lLineByte + j;

             //�����������Ǻ�ɫ��
             if(*(lpSrc)==0)

             //ͳ�Ʊ�����1
                sum++;
		  }
         data[k][i]=sum;
	  }

    //ͳ��ÿ�е����ص����
    for(j=k*lSwidth;j<(k+1)*lSwidth;j++)
	{    
        //��ͳ�Ʊ�����ʼ��
	 	  sum=0;

          //��ÿ����������ɨ��
         for(i=0;i<lSheight;i++)
          {
            // ָ��ͼ���i�е�j�и����ص�ָ��
            lpSrc = lpDIBBits + i*lLineByte + j;

             //�����������Ǻ�ɫ��
             if(*(lpSrc)==0)

             //ͳ�Ʊ�����1
                sum++;
		  }
         data[k][j-k*lSwidth+lSheight]=sum;
	  }

   }
 
//����������������
   return(data);  
}

/*******************************************************************
*
*�������ƣ�
*	TZTQ_13
*������
*	HDIB hDIB				-����ȡ������λͼ�ľ��
*	int num					-�ַ�����Ŀ
*	int dim					-��ȡ������ά��������̶�Ϊ13
*˵����
*	ͼ���Ϊ8�飬��Ϊ8������������������Ϊһ��������ˮƽ�и��ȥ�����ߣ���*��������������ֱ���������ܹ��õ�13������
*
*********************************************************************/
double * * TZTQ_13(HDIB hDIB,int num,int dim)
{	
int i,j,k,m;

	//����һ���ڴ�ռ䲢�õ���άָ��
	double * * tezheng=alloc_2d_dbl(num,dim);

	//����ͼ��������ȡ��ָ��
	BYTE* lpDIB=(BYTE*)::GlobalLock ((HGLOBAL)hDIB);

	//ȡ��ͼ����������������ʼ��ַ
	BYTE* lpDIBBits=(BYTE*)::FindDIBBits((char*)lpDIB);
	BYTE* lpSrc;	

	//��ȡͼ��߶�
	LONG lHeight=::DIBHeight ((char*)lpDIB);

	//��ȡͼ����
	LONG lWidth=::DIBWidth ((char*)lpDIB);

	LONG width=lWidth/num;
	//ÿ�е��ֽ���
	LONG lLineBytes = WIDTHBYTES(lWidth * 8);

	int b;

	//�洢��ʱ������
	double * tz=new double[dim];

	for(k=0;k<num;k++)
	{	
		for(i=0;i<dim;i++) tz[i]=0;

		//��ȡǰ8������
		for(m=0;m<8;m++)
		{	for(i=int(m/2)*8;i<(int(m/2)+1)*8;i++)
				for(j=m%2*8+k*width;j<(m%2+1)*8+k*width;j++)
				{	lpSrc=(unsigned char*)lpDIBBits + lLineBytes *  i + j;
					b=(*lpSrc==255)?0:1;
				    tz[m]+=b;
				}
		}

		//��ȡ��9������-������ֵ
		for(i=0;i<lHeight;i++)
			for(j=k*width;j<(k+1)*width;j++)
			{	lpSrc=(unsigned char*)lpDIBBits + lLineBytes *  i + j;
				b=(*lpSrc==255)?0:1;
			    tz[8]+=b;
			}

		//��ȡ��10��11������-ˮƽɨ���и�
			i=int(lHeight*1/3);
			for(j=k*width;j<(k+1)*width;j++)
			{	lpSrc=(unsigned char*)lpDIBBits + lLineBytes *  i + j;
				b=(*lpSrc==255)?0:1;
			    tz[9]+=b;
			}
			//
			i=int(lHeight*2/3);
			for(j=k*width;j<(k+1)*width;j++)
			{	lpSrc=(unsigned char*)lpDIBBits + lLineBytes *  i + j;
				b=(*lpSrc==255)?0:1;
			    tz[10]+=b;
			}

		//��ȡ��12��13������-��ֱɨ���и�
			j=int(k*width+width*1/3);
			for(i=0;i<lHeight;i++)
			{	lpSrc=(unsigned char*)lpDIBBits + lLineBytes *  i + j;
				b=(*lpSrc==255)?0:1;
			    tz[11]+=b;
			}
			
			j=int(k*width+width*2/3);
			for(i=0;i<lHeight;i++)
			{	lpSrc=(unsigned char*)lpDIBBits + lLineBytes *  i + j;
				b=(*lpSrc==255)?0:1;
			    tz[12]+=b;
			}

		//�洢����
		for(i=0;i<dim;i++)
			tezheng[k][i]=tz[i];
	}

	::GlobalUnlock ((HGLOBAL)hDIB);
	//�����������������ָ��
	return tezheng;
}

/**********************************
* �������� code()
*
* ������
*   BYTE* lpDIBBits   -ָ������ͼ���������ʵλ�õ�ָ�� 
*   int num           -ͼƬ�������ĸ���
*   LONG lLineByte    -����ͼƬÿ�е��ֽ���
*   LONG lSwidth      -Ԥ����ʱ��һ���Ŀ��
*   LONG lSheight     -Ԥ����ʱ��һ���ĳ���
*
*  �������� ��
*      ��������������ȡ����������������ѹ�һ��������
*	   ÿһ�����ض���Ϊ������ȡ����
**************************************/

double** code (BYTE* lpDIBBits,int num, LONG lLineByte,LONG lSwidth,LONG lSheight)
{   
	//ѭ������
    int i,j,k;
    BYTE* lpSrc; 
	
    //  �����������������Ķ�ά����
	double **data;
	
	// Ϊ������������ά�洢�ռ�
	data = alloc_2d_dbl(num,lSwidth*lSheight);
	
	// ����һ����������ÿ��������Ϊһ����������ȡ����
	
	//�������ɨ��
	for(k=0;k<num;k++)  
	{ 
		//��ÿ����������ɨ��
		for(i=0;i<lSheight;i++)
		{  
			//��ÿ����������ɨ��
			for(j=k*lSwidth;j<(k+1)*lSwidth;j++)
			{
				
				// ָ��ͼ���i�е�j�и����ص�ָ��
				lpSrc = lpDIBBits + i*lLineByte + j;
				
				//�����������Ǻ�ɫ��
				if(*(lpSrc)==0)
					//��������������Ӧλ����1
					data[k][i*lSwidth+j-k*lSwidth]=1;
				//������������������   
				if(*(lpSrc)!=0)
					//��������������Ӧλ����0
					data[k][i*lSwidth+j-k*lSwidth]=0;
				
				
			}
		}
	}
	
	return(data);  
}

/****************************************************
* �������� BpTrain()
* 
* ������
*   double **data_in    -ָ��������������������ָ��    
*	double **data_out   -ָ��������������ָ��
*	int n_in            -�������ĸ��� 
*   int n_hidden        -BP�������������Ŀ
*   double min_ex       -ѵ��ʱ��������������
*   double momentum     -BP��������ϵ��
*   double eta          -BP�����ѵ������
*   int num             -���������ĸ���
*
* �������ܣ�
*     ����������������������������������BP���羡��ѵ��
*     ѵ��������Ȩֵ���沢��ѵ���Ľ����ʾ����
********************************************************/
void BpTrain(double ** data_in, double** data_out,int n_in,int n_hidden,double min_ex,double momentum,double eta ,int num)
{
	
	
	
	//ѭ������   
	int i,k,l;
	
	//���������Ŀ
	int  n_out=4;   
	//ָ����������ݵ�ָ��
	double* input_unites; 
	//ָ���������ݵ�ָ��
	double* hidden_unites;
	//ָ����������ݵ�ָ��
	double* output_unites; 
	//ָ������������ݵ�ָ��
	double* hidden_deltas;
	//ָ���������������ָ��
	double* output_deltas;  
	//ָ������Ŀ�������ָ��
	double* target;    
	//ָ�������������֮��Ȩֵ��ָ��
	double** input_weights;
	//ָ�������������֮���Ȩֵ��ָ��
	double** hidden_weights;
	//ָ����һ�������������֮��Ȩֵ��ָ��
	double** input_prev_weights ;
	//ָ����һ�������������֮���Ȩֵ��ָ��
	double** hidden_prev_weights;
	//ÿ��ѭ����ľ���������ֵ 
	double ex;
	
	//Ϊ�������ݽṹ�����ڴ�ռ�
	input_unites= alloc_1d_dbl(n_in + 1);
	hidden_unites=alloc_1d_dbl(n_hidden + 1);
	output_unites=alloc_1d_dbl(n_out + 1);
	hidden_deltas = alloc_1d_dbl(n_hidden + 1);
	output_deltas = alloc_1d_dbl(n_out + 1);
	target = alloc_1d_dbl(n_out + 1);
	input_weights=alloc_2d_dbl(n_in + 1, n_hidden + 1);
	input_prev_weights = alloc_2d_dbl(n_in + 1, n_hidden + 1);
	hidden_prev_weights = alloc_2d_dbl(n_hidden + 1, n_out + 1);
	hidden_weights = alloc_2d_dbl(n_hidden + 1, n_out + 1);
	
	//Ϊ���������������
	time_t t; 
	bpnn_initialize((unsigned)time(&t));
	
	//�Ը���Ȩֵ���г�ʼ����ʼ��
	bpnn_randomize_weights( input_weights,n_in,n_hidden);
	bpnn_randomize_weights( hidden_weights,n_hidden,n_out);
	bpnn_zero_weights(input_prev_weights, n_in,n_hidden );
	bpnn_zero_weights(hidden_prev_weights,n_hidden,n_out );
	
	//��ʼ����BP����ѵ��
	//�����趨���ĵ�������Ϊ15000��
	for(l=0;l<15000;l++)  
	{ 
		//�Ծ����������
		ex=0;
		//���������������ɨ��
		for(k=0;k<num;k++)  
		{ 
			//����ȡ�������������������͵��������
			for(i=1;i<=n_in;i++)
				input_unites[i] = data_in[k][i-1];
			
			//��Ԥ��������������͵�BP��������������Ԫ
			for(i=1;i<=n_out;i++)
				target[i]=data_out[k][i-1];
			
			//ǰ���伤��
			
			//������������㴫������ 
			bpnn_layerforward(input_unites,hidden_unites,
				input_weights, n_in,n_hidden);
			//�������������������
			bpnn_layerforward(hidden_unites, output_unites,
				hidden_weights,n_hidden,n_out);
			
			//������
			
			//���������������������Ƚϼ��������ÿ������ϵ����
			bpnn_output_error(output_deltas,target,output_unites,n_out);
			//������������ϵ�����������ÿ���ڵ��ϵ����
			bpnn_hidden_error(hidden_deltas,n_hidden, output_deltas, n_out,hidden_weights, hidden_unites);
			
			//Ȩֵ����
			//���������ÿ���ڵ��ϵ���������������������֮���Ȩֵ    
			bpnn_adjust_weights(output_deltas,n_out, hidden_unites,n_hidden,
				hidden_weights, hidden_prev_weights, eta, momentum); 
			//��������ÿ���ڵ��ϵ���������������������֮���Ȩֵ    	
			bpnn_adjust_weights(hidden_deltas, n_hidden, input_unites, n_in,
				input_weights, input_prev_weights, eta, momentum);  
			
			//���ͳ��		
			for(i=1;i<=n_out;i++)
				ex+=(output_unites[i]-data_out[k][i-1])*(output_unites[i]-data_out[k][i-1]);
		}
		//����������
		ex=ex/double(num*n_out);
		//�����������Ѿ��㹻��С������ѭ����ѵ�����  
		if(ex<min_ex)break;
	}
	
	//��ر���
	
	//���������������֮���Ȩֵ
	w_weight(input_weights,n_in,n_hidden,"win.dat");
	//���������������֮���Ȩֵ
	w_weight(hidden_weights,n_hidden,n_out,"whi.dat");
	
	//���������ĸ���
	w_num(n_in,n_hidden,n_out,"num");
	
	//��ʾѵ�����
	
	CString str;
	if(ex<=min_ex)
	{
		str.Format ("����%d�Σ�\nƽ�����%.4f",l,ex);
		
		::MessageBox(NULL,str,"ѵ�����",NULL);
	}
	
	if(ex>min_ex)
	{
		
		str.Format("����%d�Σ�ƽ�����%.4f\n���Ѿ��������Ŭ���˻��Ǵﲻ������Ҫ��\n�������������ѵ���ɣ�",l,ex);
		::MessageBox(NULL,str,"ѵ�����",NULL);
	}
	
	//�ͷ��ڴ�ռ�
	
	free(input_unites);
	free(hidden_unites);
	free(output_unites);
	free(hidden_deltas);
	free(output_deltas);
	free(target);
	free(input_weights);
	free(hidden_weights);
	free(input_prev_weights);
	free(hidden_prev_weights);
}

/*******************************************
* ��������
* CodeRecognize()
* ����
*  double **data_in     -ָ���ʶ����������������ָ��
*  int num              -��ʶ��������ĸ��� 
*  int n_in             -Bp�����������ĸ���              
*  int n_hidden         -Bp����������ĸ���
*  int n_out            -Bp�����������ĸ���
* �������ܣ�  
*    ����������������������������ѵ�����õ�Ȩֵ 
*    ����ʶ�𣬽�ʶ��Ľ��д��result.txt 
****************************************/

void CodeRecognize(double **data_in, int num ,int n_in,int n_hidden,int n_out)
{
	//ѭ������
	int i,k;
	// ָ��ʶ������ָ�� 
	int *recognize;
	//Ϊ���ʶ��Ľ������洢�ռ�
	recognize=(int*)malloc(num*sizeof(int));
	
	//ָ����������ݵ�ָ��
	double* input_unites; 
	//ָ���������ݵ�ָ��
	double* hidden_unites;
	//ָ����������ݵ�ָ��
	double* output_unites; 
	//ָ�������������֮��Ȩֵ��ָ��
	double** input_weights;
	//ָ�������������֮���Ȩֵ��ָ��
	double** hidden_weights;
	//Ϊ�������ݽṹ�����ڴ�ռ�
	input_unites= alloc_1d_dbl(n_in + 1);
	hidden_unites=alloc_1d_dbl(n_hidden + 1);
	output_unites=alloc_1d_dbl(n_out + 1);
	input_weights=alloc_2d_dbl(n_in + 1, n_hidden + 1);
	hidden_weights = alloc_2d_dbl(n_hidden + 1, n_out + 1);
	
	
	//��ȡȨֵ
	if( r_weight(input_weights,n_in,n_hidden,"win.dat")==false)
		return;
	if(r_weight(hidden_weights,n_hidden,n_out,"whi.dat")==false)
		return;
	
	
	//�������ɨ��
	for(k=0;k<num;k++)
	{ 
		//����ȡ�������������������͵��������
		for(i=1;i<=n_in;i++)
			input_unites[i]=data_in[k][i-1];
		
		//ǰ�����뼤��
        bpnn_layerforward(input_unites,hidden_unites,
			input_weights, n_in,n_hidden);
        bpnn_layerforward(hidden_unites, output_unites,
			hidden_weights,n_hidden,n_out);
		
		//��������������ʶ��
		int result=0 ;
		//����ÿһλ�����
		for(i=1;i<=n_out;i++)
		{
			//�������0.5��Ϊ1
			if(output_unites[i]>0.5)
				
				result+=(int)pow(2,double(4-i));
		}
		
		//����ж��Ľ��С�ڵ���9����Ϊ����
		if(result<=9)
			recognize[k]=result;
		//����ж��Ľ������9����Ϊ�����������λΪһ������ֵ20
		if(result>9)
			recognize[k]=20;
	}
	
	
	//��ʶ����д���ı���
	FILE *fp;
	fp=fopen("result.txt","w+");
	
	for(i=0;i<num;i++)
	{  
		if(recognize[i]==20)
			fprintf(fp,"�޷�ʶ��");
		else
			fprintf(fp,"%d,",recognize[i]);
		
	}
	fclose(fp);
	
	//��ʶ��Ľ����ʾ����
	CString str,str1;
	for(i=0;i<num;i++)
	{
		if(recognize[i]!=20)
			str.Format("%d ",recognize[i]);
		
		if(recognize[i]==20)
			str.Format("�޷�ʶ�� ");
		
		str1+=str;
	}
	
	//֪ͨ�û�ѵ�����
	
	
	::MessageBox(NULL,str1,"ʶ����",NULL);
	
	//�ͷŴ洢�ռ�
	free(input_unites);
	free(hidden_unites);
	free(output_unites);
	free(input_weights);
	free(hidden_weights);
}


