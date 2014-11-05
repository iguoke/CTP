#ifndef __ENUM_H_
#define __ENUM_H_


//��������
typedef enum TradeType
{
  Back,
  Simulation,
  Real
} TradeType;
//API
typedef enum EnumAPI
{
  CTP,
  FRMAS,
  XSPEE,
  Esunny,
  HBLTS,
  GSFIX
} EnumAPI;
//Exchange
typedef enum EnumExchange
{
  CFFEX,
  DCE,
  CZCE,
  SHFE,
  SSE,
  SZSE
} EnumExchange;
//�г��ṹ
typedef enum EnumMarket
{
 Stock,
 Bonds,
 Forex,
 Futures,
 Options,
 ETF
} EnumMarket;
//BarType
typedef enum EnumBarType
{
 Tick,
 Second,
 Minute, 
 Hour, 
 Day, 
 Week,
 Month, 
 Year
} EnumBarType;
//��������
typedef enum EnumDirection
{
  BuyDirection,
  SellDirection
} EnumDirection;
//��������
typedef enum EnumContingentCondition
{
  Immediately, //����  
  Touch, //ֹ��  
  TouchProfit, // ֹӮ  
  ParkedOrder, // Ԥ��  
  LastPriceGreaterThanStopPrice, // ���¼۴���������  
  LastPriceGreaterEqualStopPrice, // ���¼۴��ڵ���������  
  LastPriceLesserThanStopPrice, // ���¼�С��������  
  LastPriceLesserEqualStopPrice, // ���¼�С�ڵ���������  
  AskPriceGreaterThanStopPrice, // ��һ�۴���������  
  AskPriceGreaterEqualStopPrice, // ��һ�۴��ڵ���������  
  AskPriceLesserThanStopPrice, // ��һ��С��������  
  AskPriceLesserEqualStopPrice, // ��һ��С�ڵ���������  
  BidPriceGreaterThanStopPrice, // ��һ�۴���������  
  BidPriceGreaterEqualStopPrice, // ��һ�۴��ڵ���������  
  BidPriceLesserThanStopPrice, // ��һ��С��������  
  BidPriceLesserEqualStopPrice //��һ��С�ڵ���������
} EnumContingentCondition;
//�������߻��ഩ����ϵ 
typedef enum EnumCross
{
  Above , //�ϴ�  
  Below , //�´�  
  None  //��  
} EnumCross;
//�ڻ�ί��״̬ 
typedef enum EnumFutureOrderStatus
{
  Waste  ,// �ϵ�  
  Tobereported  , //����  
  Reported // �ѱ�  
} EnumFutureOrderStatus;
//Ͷ���ױ���־
typedef enum EnumHedgeFlag
{
  Speculation ,// Ͷ��  
  Arbitrage ,// ����  
  Hedge //�ױ�
} EnumHedgeFlag;
//����ѡ��
typedef enum EnumIndexOption
{
    Null,//û��
    Next,//��ǰ
    Prev//���
} EnumIndexOption;
//��Լ��������
typedef enum EnumLifeStatus
{
    Maturity, //δ����
    Listed ,//����
    Suspended,// ͣ��
    Unlisted //����
} EnumLifeStatus;
//����ṹ
typedef enum EnumNetType
{
  UniCom ,//��ͨ  
  TeleCom //����
} EnumNetType;
//�ر�ģʽ
typedef enum RESUMETYPE
{
	RESTART,
	RESUME,
	QUICK
} RESUMETYPE;

//��ƽ��
typedef enum EnumOpenClose
{
  Open ,// ����  
  Close ,// ƽ��  
  CloseToday, // ƽ��  
  StrongClose ,// ǿƽ  
  StrongReduction//ǿ��
} EnumOpenClose;
//����״̬����
typedef enum EnumOrderStatus
{
  AllTraded ,// ȫ���ɽ�  
  PartTradedQueueing ,// ���ֳɽ����ڶ�����  
  PartTradedNotQueueing ,// ���ֳɽ����ڶ�����  
  NoTradeQueueing ,// δ�ɽ����ڶ�����  
  NoTradeNotQueueing ,// δ�ɽ����ڶ�����  
  Canceled ,// ����  
  Unknown ,// δ֪  
  NotTouched ,// ��δ����  
  Touched // �Ѵ���  
} EnumOrderStatus;
//��һ�������ύ״̬����
typedef enum EnumOrderSubmitStatus
{
  InsertSubmitted ,// �Ѿ��ύ  
 CancelSubmitted ,// �����Ѿ��ύ  
 ModifySubmitted ,// �޸��Ѿ��ύ  
 Accepted ,// �Ѿ�����  
 InsertRejected ,// �����Ѿ����ܾ�  
 CancelRejected ,// �����Ѿ����ܾ�  
 ModifyRejected // �޸��Ѿ����ܾ�  
} EnumOrderSubmitStatus;
//�������� 
typedef enum EnumOrderType
{
  Normal ,//����  
 DeriveFromQuote ,// ��������  
 DeriveFromCombination ,// �������  
 Combination ,// ��ϱ���  
 ConditionalOrder ,// ������  
 Swap //������
} EnumOrderType;
//��һ��Ԥ��״̬����
typedef enum EnumParkedOrderStatus
{
  NotSend ,//δ����  
 Send ,// �ѷ���  
 Deleted // ��ɾ��  
} EnumParkedOrderStatus;
//�ֲ���������
typedef enum EnumPositionDate
{
  Today,
  History
} EnumPositionDate ;
//�ڻ��ֲַ��� 
typedef enum EnumPositionDirection
{
 Long,
 Short,
 Netpositions//���ֲ�
} EnumPositionDirection;
//�ɽ�����Դ 
typedef enum EnumPriceSource
{
  LastPrice ,// ǰ�ɽ���  
 Buy ,// ��ί�м�  
 Sell //��ί�м�
} EnumPriceSource;
//�������ܾ�ԭ��
typedef enum  EnumRejectReason
{
  Superlicense,// �ѳ����������ܾ��ۺϽ���ƽ̨��������ÿ�뷢�����������������  
 Nonminimumunit ,// �ѳ����������ܾ��۸����С��λ�ı���  
 Higherthanlimit ,// �ѳ����������ܾ��۸�������ͣ��  
 Lowerthanlimit ,// �ѳ����������ܾ��۸���Ƶ�ͣ��  
 Lackoffunds ,// �ۺϽ���ƽ̨���ʽ���  
 Lackoftodaypostion ,// �ۺϽ���ƽ̨��ƽ���λ����  
 Lackofhistorypostion ,// �ۺϽ���ƽ̨��ƽ���λ����  
 Nonsupportordertype  ,// �ѳ����������ܾ�����֧�ֵı�������  
 NonsupportHedgetype ,// �ý�������֧���������ͱ���  
 //��ֵ��Ȳ��� 9 �ѳ����������ܾ���ֵ��Ȳ���  
 Nonnetconnect ,// ��������ʧ��  
 Delayorder ,// ί���������������ƣ��ܾ��ӳٷ��Ϳ��ֵ�  
 Stop ,// ��ͣ���Ϳ��ֵ�XX��  
 Undown 
} EnumRejectReason;
//��Ȩ��ʽ
typedef enum EnumRestoration
{
 NonR,
 PreR,
 NextR
} EnumRestoration;
//��������
typedef enum EnumSound
{
 Alarm ,  
 Beep ,  
 Chimes ,  
 Clear ,  
 Ding ,  
 Error, 
 Logout ,  
 Notenough ,  
 Notify ,  
 Ring 
} EnumSound;
//��������-�����ɹ��������� 
typedef enum EnumAfterCancel
{
 NonA,//�޲���
 Reorder//�ط�ί�� 
} EnumAfterCancel;
//������ʽ
typedef enum EnumTriggerMode
{
  Ticker,
  Timer,
  Barer
} EnumTriggerMode;
//�г�״̬ 
typedef enum EnumMarketState
{
  Auction,//���Ͼ��� 0  
  Continuous,//�������� 1  
  MiddayRest,//������� 2  
  Closed//���� 3  
} EnumMarketState;

#endif
