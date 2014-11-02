//public class Strategy : IStrategy
//{
//    // Fields
//    private IFunction _fuction;

//    // Methods
//    public void AddIndicator(Indicator indicator)
//    {
//        if (this._fuction != null)
//        {
//            this._fuction.AddIndicator(indicator);
//        }
//    }

//    public DateTime AgoExchangeTime(double seconds, EnumExchange exchange)
//    {
//        return this.AgoExchangeTime(seconds, this.GetExchange(exchange));
//    }

//    public DateTime AgoExchangeTime(double seconds, Exchange exchange)
//    {
//        return this._fuction.AgoMarketTime(seconds, exchange);
//    }

//    public double AgoFuturePrice(int n)
//    {
//        if (this.DefaultFutureCode != "")
//        {
//            return this.AgoFuturePrice(this.DefaultFutureCode, n);
//        }
//        this.Print("Error:DefaultFutureCode is null!");
//        return double.NaN;
//    }

//    public double AgoFuturePrice(string FutureCode, int n)
//    {
//        if (this.AllFutures.Contains(FutureCode))
//        {
//            Tick tick = this.AgoFutureTick(FutureCode, n);
//            if (tick != null)
//            {
//                return tick.LastPrice;
//            }
//            this.Print("错误AgoFutureTick(" + FutureCode + "," + n.ToString() + ") = null!");
//            return double.NaN;
//        }
//        this.Print("没有订阅期货[" + FutureCode + "]");
//        return double.NaN;
//    }

//    public Tick AgoFutureTick(int n)
//    {
//        if (this.DefaultFutureCode != "")
//        {
//            Tick tick = this._fuction.AgoFutureTick(this.DefaultFutureCode, n);
//            if (tick == null)
//            {
//                this.Print("错误AgoFutureTick(" + this.DefaultFutureCode + "," + n.ToString() + ") = null!");
//            }
//            return tick;
//        }
//        this.Print("错误:DefaultFutureCode为空!");
//        return null;
//    }

//    public Tick AgoFutureTick(string FutureCode, int n)
//    {
//        if (this.AllFutures.Contains(FutureCode))
//        {
//            Tick tick = this._fuction.AgoFutureTick(FutureCode, n);
//            if (tick == null)
//            {
//                this.Print("错误AgoFutureTick(" + FutureCode + "," + n.ToString() + ") = null!");
//            }
//            return tick;
//        }
//        this.Print("没有订阅期货[" + FutureCode + "]");
//        return null;
//    }

//    public double AgoStockPrice(int n)
//    {
//        if (this.DefaultStockCode != "")
//        {
//            return this.AgoStockPrice(this.DefaultStockCode, n);
//        }
//        this.Print("错误:DefaultStockCode为空");
//        return double.NaN;
//    }

//    public double AgoStockPrice(string StockCode, int n)
//    {
//        if (this.AllStocks.Contains(StockCode))
//        {
//            Tick tick = this.AgoStockTick(StockCode, n);
//            if (tick != null)
//            {
//                return tick.LastPrice;
//            }
//            this.Print("错误AgoStockTick(" + StockCode + "," + n.ToString() + ") = null!");
//            return double.NaN;
//        }
//        this.Print("没有订阅股票[" + StockCode + "]");
//        return double.NaN;
//    }

//    public Tick AgoStockTick(int n)
//    {
//        if (this.DefaultStockCode != "")
//        {
//            Tick tick = this._fuction.AgoStockTick(this.DefaultStockCode, n);
//            if (tick == null)
//            {
//                this.Print("Error:AgoStockTick(" + this.DefaultStockCode + "," + n.ToString() + ") = null!");
//            }
//            return tick;
//        }
//        this.Print("错误:DefaultStockCode为空");
//        return null;
//    }

//    public Tick AgoStockTick(string StockCode, int n)
//    {
//        if (this.AllStocks.Contains(StockCode))
//        {
//            Tick tick = this._fuction.AgoStockTick(StockCode, n);
//            if (tick == null)
//            {
//                this.Print("Error:AgoStockTick(" + StockCode + "," + n.ToString() + ") = null!");
//            }
//            return tick;
//        }
//        this.Print("没有订阅股票[" + StockCode + "]");
//        return null;
//    }

//    public Order BuyStock(string StockCode, int Amount, double Price)
//    {
//        if (Amount <= 0)
//        {
//            this.Print("$买入" + StockCode + "股数不能小于等于0!");
//            return null;
//        }
//        Order order = this._fuction.BuyStock(StockCode, Amount, Price);
//        this.Print("$买入" + Amount.ToString() + "股[" + StockCode + "]限价" + Price.ToString() + "元@" + this.Now.ToString("HH:mm:ss.fff"));
//        return order;
//    }

//    public void CancelAllFutureOrders()
//    {
//        OrderSeries canCancelFutureOrders = this.GetCanCancelFutureOrders();
//        if ((canCancelFutureOrders == null) || (canCancelFutureOrders.Count <= 0))
//        {
//            this.Print("$可撤单列表为空，无需执行撤单操作CancelAllFutureOrders");
//        }
//        else
//        {
//            List<string> list = new List<string>();
//            foreach (Order order in canCancelFutureOrders)
//            {
//                list.Add(order.OrderSysID);
//            }
//            foreach (string str in list)
//            {
//                Order futureOrder = this.GetFutureOrder(str);
//                if ((futureOrder != null) && this.AllFutures.Contains(futureOrder.InstrumentID))
//                {
//                    this.CancelFutureOrder(futureOrder);
//                }
//            }
//        }
//    }

//    public void CancelAllFutureOrders(int idx)
//    {
//        OrderSeries canCancelFutureOrders = this.GetCanCancelFutureOrders(idx);
//        if ((canCancelFutureOrders == null) || (canCancelFutureOrders.Count <= 0))
//        {
//            this.Print("$可撤单列表为空，无需执行撤单操作CancelAllFutureOrders");
//        }
//        else
//        {
//            List<string> list = new List<string>();
//            foreach (Order order in canCancelFutureOrders)
//            {
//                list.Add(order.OrderSysID);
//            }
//            foreach (string str in list)
//            {
//                Order futureOrder = this.GetFutureOrder(str, idx);
//                if ((futureOrder != null) && this.AllFutures.Contains(futureOrder.InstrumentID))
//                {
//                    this.CancelFutureOrder(futureOrder);
//                }
//            }
//        }
//    }

//    public void CancelAllFutureOrders(string accid)
//    {
//        OrderSeries canCancelFutureOrders = this.GetCanCancelFutureOrders(accid);
//        if ((canCancelFutureOrders == null) || (canCancelFutureOrders.Count <= 0))
//        {
//            this.Print("$可撤单列表为空，无需执行撤单操作CancelAllFutureOrders");
//        }
//        else
//        {
//            List<string> list = new List<string>();
//            foreach (Order order in canCancelFutureOrders)
//            {
//                list.Add(order.OrderSysID);
//            }
//            foreach (string str in list)
//            {
//                Order futureOrder = this.GetFutureOrder(str, accid);
//                if ((futureOrder != null) && this.AllFutures.Contains(futureOrder.InstrumentID))
//                {
//                    this.CancelFutureOrder(futureOrder);
//                }
//            }
//        }
//    }

//    public bool CancelFutureOrder(Order order)
//    {
//        bool flag = this._fuction.CancelFutureOrder(order);
//        string msg = "#期货撤单";
//        if (flag)
//        {
//            msg = msg + "提交:";
//        }
//        else
//        {
//            msg = msg + "提交异常:";
//        }
//        object obj2 = msg;
//        msg = string.Concat(new object[] { 
//            obj2, order.OpenOrClose.ToString(), order.Direction.ToString(), " ", order.Volume.ToString(), "手[", order.InstrumentID, "],已成交", order.VolumeTraded.ToString(), ",剩余", order.VolumeLeft, ",限价", order.LimitPrice.ToString(), ",委托报入于", order.InsertTime.ToString(), "@", 
//            this.Now.ToString("HH:mm:ss.fff")
//         });
//        this.Print(msg);
//        return flag;
//    }

//    public bool CancelFutureOrder(string OrderID)
//    {
//        if ((OrderID == null) || (OrderID == ""))
//        {
//            this.Print("$期货委托撤单ID不合法");
//            return false;
//        }
//        Order futureOrder = this.GetFutureOrder(OrderID);
//        if (futureOrder == null)
//        {
//            this.Print("$撤单没有查询到期货委托[" + OrderID + "]");
//            return false;
//        }
//        return this.CancelFutureOrder(futureOrder);
//    }

//    public bool CancelFutureOrder(string OrderID, int idx)
//    {
//        if ((OrderID == null) || (OrderID == ""))
//        {
//            this.Print("$期货委托撤单ID不合法");
//            return false;
//        }
//        Order futureOrder = this.GetFutureOrder(OrderID, idx);
//        if (futureOrder == null)
//        {
//            this.Print("$没有查询到期货委托[" + OrderID + "]");
//            return false;
//        }
//        return this.CancelFutureOrder(futureOrder);
//    }

//    public bool CancelFutureOrder(string OrderID, string accid)
//    {
//        if ((OrderID == null) || (OrderID == ""))
//        {
//            this.Print("$期货委托撤单ID不合法");
//            return false;
//        }
//        if ((accid == null) || (accid == ""))
//        {
//            this.Print("$期货委托撤单账户不合法");
//            return false;
//        }
//        Order futureOrder = this.GetFutureOrder(OrderID, accid);
//        if (futureOrder == null)
//        {
//            this.Print("$没有查询到期货委托[" + OrderID + "]");
//            return false;
//        }
//        return this.CancelFutureOrder(futureOrder);
//    }

//    public bool CancelStockOrder(Order order)
//    {
//        bool flag = this._fuction.CancelStockOrder(order);
//        if (flag)
//        {
//            this.Print("$提交股票撤单成功[" + order.InstrumentID + "]" + order.Direction.ToString() + "委托ID=" + order.OrderSysID + "@" + this.Now.ToString("HH:mm:ss.fff"));
//            return flag;
//        }
//        this.Print("$提交股票撤单失败[" + order.InstrumentID + "]" + order.Direction.ToString() + "委托ID=" + order.OrderSysID + "@" + this.Now.ToString("HH:mm:ss.fff"));
//        return flag;
//    }

//    public void ClearPositions()
//    {
//        this.ClearPositions(0);
//    }

//    public void ClearPositions(int jump)
//    {
//        this.ClearPositions(jump, 0);
//    }

//    public void ClearPositions(int jump, int idx)
//    {
//        string msg = "";
//        PositionSeries futurePositions = this.GetFuturePositions(idx);
//        if ((futurePositions != null) && (futurePositions.Count > 0))
//        {
//            foreach (Position position in futurePositions)
//            {
//                string instrumentID = position.InstrumentID;
//                int volumn = position.Volumn;
//                if (this.AllFutures.Contains(instrumentID) && (position.Volumn > 0))
//                {
//                    Future future = this.AllFutures[instrumentID];
//                    Tick lastTick = future.LastTick;
//                    if ((lastTick != null) && (lastTick.LastPrice > 0.0))
//                    {
//                        double lastPrice = lastTick.LastPrice;
//                        double num3 = lastTick.LastPrice;
//                        double priceTick = future.PriceTick;
//                        if (position.PosiDirection == EnumPositionDirection.多头)
//                        {
//                            if (lastTick.BidPrice1 > 0.0)
//                            {
//                                num3 = lastTick.BidPrice1;
//                            }
//                            lastPrice = num3 - (priceTick * jump);
//                            lastPrice = this.TrimFuturePrice(future, lastPrice);
//                            msg = ((((("清仓[" + instrumentID + "]") + ",最新价=" + num3.ToString()) + ",跳=" + -jump.ToString()) + ",最小价格变动单位=" + priceTick.ToString()) + ",委托价=" + lastPrice.ToString()) + ",方向=卖出";
//                            this.Print(msg);
//                            if (volumn > 0)
//                            {
//                                this.Print("#平今卖出" + volumn.ToString() + instrumentID);
//                                this.LimitOrder(instrumentID, volumn, lastPrice, EnumBuySell.卖出, EnumOpenClose.平今仓, idx);
//                            }
//                            else
//                            {
//                                this.Print("不能平仓,平今量=" + volumn);
//                            }
//                            continue;
//                        }
//                        if (position.PosiDirection == EnumPositionDirection.空头)
//                        {
//                            if (lastTick.AskPrice1 > 0.0)
//                            {
//                                num3 = lastTick.AskPrice1;
//                            }
//                            lastPrice = num3 + (priceTick * jump);
//                            lastPrice = this.TrimFuturePrice(future, lastPrice);
//                            msg = ((((("清仓[" + instrumentID + "]") + ",最新价=" + num3.ToString()) + ",跳=" + jump.ToString()) + ",最小价格变动单位=" + priceTick.ToString()) + ",委托价=" + lastPrice.ToString()) + ",方向=买入";
//                            this.Print(msg);
//                            if (volumn > 0)
//                            {
//                                this.Print("#平今买入" + volumn.ToString() + instrumentID);
//                                this.LimitOrder(instrumentID, volumn, lastPrice, EnumBuySell.买入, EnumOpenClose.平今仓, idx);
//                                continue;
//                            }
//                            this.Print("不能平仓,平今量=" + volumn);
//                        }
//                    }
//                }
//            }
//        }
//        else
//        {
//            this.Print("$ClearPositions清仓时发现持仓列表为空");
//        }
//    }

//    public void ClearPositions(int jump, string accid)
//    {
//        string msg = "";
//        PositionSeries futurePositions = this.GetFuturePositions(accid);
//        if ((futurePositions != null) && (futurePositions.Count > 0))
//        {
//            foreach (Position position in futurePositions)
//            {
//                string instrumentID = position.InstrumentID;
//                int volumn = position.Volumn;
//                if (this.AllFutures.Contains(instrumentID) && (position.Volumn > 0))
//                {
//                    Future future = this.AllFutures[instrumentID];
//                    Tick lastTick = future.LastTick;
//                    if ((lastTick != null) && (lastTick.LastPrice > 0.0))
//                    {
//                        double lastPrice = lastTick.LastPrice;
//                        double num3 = lastTick.LastPrice;
//                        double priceTick = future.PriceTick;
//                        if (position.PosiDirection == EnumPositionDirection.多头)
//                        {
//                            if (lastTick.BidPrice1 > 0.0)
//                            {
//                                num3 = lastTick.BidPrice1;
//                            }
//                            lastPrice = num3 - (priceTick * jump);
//                            lastPrice = this.TrimFuturePrice(future, lastPrice);
//                            msg = ((((("清仓[" + instrumentID + "]") + ",最新价=" + num3.ToString()) + ",跳=" + -jump.ToString()) + ",最小价格变动单位=" + priceTick.ToString()) + ",委托价=" + lastPrice.ToString()) + ",方向=卖出";
//                            this.Print(msg);
//                            if (volumn > 0)
//                            {
//                                this.Print("#平今卖出" + volumn.ToString() + instrumentID);
//                                this.LimitOrder(instrumentID, volumn, lastPrice, EnumBuySell.卖出, EnumOpenClose.平今仓, accid);
//                            }
//                            else
//                            {
//                                this.Print("不能平仓,平今量=" + volumn);
//                            }
//                            continue;
//                        }
//                        if (position.PosiDirection == EnumPositionDirection.空头)
//                        {
//                            if (lastTick.AskPrice1 > 0.0)
//                            {
//                                num3 = lastTick.AskPrice1;
//                            }
//                            lastPrice = num3 + (priceTick * jump);
//                            lastPrice = this.TrimFuturePrice(future, lastPrice);
//                            msg = ((((("清仓[" + instrumentID + "]") + ",最新价=" + num3.ToString()) + ",跳=" + jump.ToString()) + ",最小价格变动单位=" + priceTick.ToString()) + ",委托价=" + lastPrice.ToString()) + ",方向=买入";
//                            this.Print(msg);
//                            if (volumn > 0)
//                            {
//                                this.Print("#平今买入" + volumn.ToString() + instrumentID);
//                                this.LimitOrder(instrumentID, volumn, lastPrice, EnumBuySell.买入, EnumOpenClose.平今仓, accid);
//                                continue;
//                            }
//                            this.Print("不能平仓,平今量=" + volumn);
//                        }
//                    }
//                }
//            }
//        }
//        else
//        {
//            this.Print("$ClearPositions清仓时发现持仓列表为空");
//        }
//    }

//    public bool DictContains(string key)
//    {
//        return this._fuction.DictContains(key);
//    }

//    public virtual void Exit()
//    {
//    }

//    public int FutureAccountIDToIdx(string accid)
//    {
//        return this._fuction.FutureAccountIDToIdx(accid);
//    }

//    public string FutureAccountIdxToID(int idx)
//    {
//        return this._fuction.FutureAccountIdxToID(idx);
//    }

//    public OrderSeries GetCanCancelFutureOrders()
//    {
//        return this._fuction.GetCanCancelFutureOrders(0);
//    }

//    public OrderSeries GetCanCancelFutureOrders(int idx)
//    {
//        return this._fuction.GetCanCancelFutureOrders(idx);
//    }

//    public OrderSeries GetCanCancelFutureOrders(string accid)
//    {
//        return this._fuction.GetCanCancelFutureOrders(accid);
//    }

//    public OrderSeries GetCanCancelStockOrders()
//    {
//        return this._fuction.GetCanCancelStockOrders();
//    }

//    public string GetDict(string key)
//    {
//        return this._fuction.GetDict(key);
//    }

//    public Exchange GetExchange(EnumExchange exch)
//    {
//        return this._fuction.GetExchange(exch);
//    }

//    public Exchange GetExchange(string ExchangeID)
//    {
//        return this._fuction.GetExchange(ExchangeID);
//    }

//    public bool GetExchangeCanTrade(EnumExchange exchange)
//    {
//        return this._fuction.MarketCanTrade(exchange);
//    }

//    public DateTime GetExchangeCloseTime(EnumExchange exchange)
//    {
//        return this._fuction.MarketCloseTime(exchange);
//    }

//    public DateTime GetExchangeOpenTime(EnumExchange exchange)
//    {
//        return this._fuction.MarketOpenTime(exchange);
//    }

//    public DateTime GetExchangeTime(EnumExchange exchange)
//    {
//        return this._fuction.ExchangeTime(exchange);
//    }

//    public FutureAccount GetFutureAccount()
//    {
//        return this._fuction.GetFutureAccount(0);
//    }

//    public FutureAccount GetFutureAccount(int idx)
//    {
//        return this._fuction.GetFutureAccount(idx);
//    }

//    public FutureAccount GetFutureAccount(string accid)
//    {
//        return this._fuction.GetFutureAccount(accid);
//    }

//    public BarSeries GetFutureBarSeries(int Interval, EnumBarType bar, DateTime beginTime)
//    {
//        BarSeries series = new BarSeries();
//        if (bar == EnumBarType.Tick)
//        {
//            this.Print("$GetFutureBarSeries为K线方法,不支持Tick");
//            return series;
//        }
//        if (this.DefaultFuture != null)
//        {
//            return this.GetFutureBarSeries(this.DefaultFutureCode, Interval, bar, beginTime);
//        }
//        this.Print("$GetFutureBarSeries失败,没有订阅期货行情");
//        return series;
//    }

//    public BarSeries GetFutureBarSeries(int Interval, EnumBarType bar, int MaxLength)
//    {
//        BarSeries series = new BarSeries();
//        if (bar == EnumBarType.Tick)
//        {
//            this.Print("GetFutureBarSeries为K线方法,不支持Tick");
//            return series;
//        }
//        if (this.DefaultFuture != null)
//        {
//            return this.GetFutureBarSeries(this.DefaultFutureCode, Interval, bar, MaxLength);
//        }
//        this.Print("GetFutureBarSeries失败,没有订阅期货行情");
//        return series;
//    }

//    public BarSeries GetFutureBarSeries(string FutureCode, int Interval, EnumBarType bar, DateTime beginTime)
//    {
//        BarSeries series = new BarSeries();
//        if (bar == EnumBarType.Tick)
//        {
//            this.Print("$GetFutureBarSeries为K线方法,不支持Tick");
//            return series;
//        }
//        if (this._fuction == null)
//        {
//            return series;
//        }
//        if (!this.AllFutures.Contains(FutureCode))
//        {
//            this.Print("$没有订阅期货[" + FutureCode + "]");
//            return series;
//        }
//        return this._fuction.GetFutureBarSeries(FutureCode, Interval, bar, beginTime, EnumRestoration.不复权);
//    }

//    public BarSeries GetFutureBarSeries(string FutureCode, int Interval, EnumBarType bar, int MaxLength)
//    {
//        BarSeries series = new BarSeries();
//        if (bar == EnumBarType.Tick)
//        {
//            this.Print("GetFutureBarSeries为K线方法,不支持Tick");
//            return series;
//        }
//        if (!this.AllFutures.Contains(FutureCode))
//        {
//            this.Print("GetFutureBarSeries失败,没有订阅期货[" + FutureCode + "]");
//            return series;
//        }
//        return this._fuction.GetFutureBarSeries(FutureCode, Interval, bar, MaxLength, EnumRestoration.不复权);
//    }

//    public BarSeries GetFutureBarSeries(string FutureCode, int Interval, EnumBarType bar, DateTime beginTime, EnumRestoration restore)
//    {
//        BarSeries series = new BarSeries();
//        if (bar == EnumBarType.Tick)
//        {
//            this.Print("$GetFutureBarSeries为K线方法,不支持Tick");
//            return series;
//        }
//        if (this._fuction == null)
//        {
//            return series;
//        }
//        if (!this.AllFutures.Contains(FutureCode))
//        {
//            this.Print("$没有订阅期货[" + FutureCode + "]");
//            return series;
//        }
//        return this._fuction.GetFutureBarSeries(FutureCode, Interval, bar, beginTime, restore);
//    }

//    public BarSeries GetFutureBarSeries(string FutureCode, int Interval, EnumBarType bar, int MaxLength, EnumRestoration restore)
//    {
//        BarSeries series = new BarSeries();
//        if (bar == EnumBarType.Tick)
//        {
//            this.Print("GetFutureBarSeries为K线方法,不支持Tick");
//            return series;
//        }
//        if (!this.AllFutures.Contains(FutureCode))
//        {
//            this.Print("GetFutureBarSeries失败,没有订阅期货[" + FutureCode + "]");
//            return series;
//        }
//        return this._fuction.GetFutureBarSeries(FutureCode, Interval, bar, MaxLength, restore);
//    }

//    public Order GetFutureOrder(string OrderID)
//    {
//        foreach (Order order in this.GetFutureOrders(0))
//        {
//            if (order.OrderSysID == OrderID)
//            {
//                return order;
//            }
//        }
//        this.Print("$查询期货委托错误:GetFutureOrder(" + OrderID + ") = null ");
//        return null;
//    }

//    public Order GetFutureOrder(string OrderID, int idx)
//    {
//        foreach (Order order in this.GetFutureOrders(idx))
//        {
//            if (order.OrderSysID == OrderID)
//            {
//                return order;
//            }
//        }
//        this.Print("$查询期货委托错误:GetFutureOrder(" + OrderID + ") = null ");
//        return null;
//    }

//    public Order GetFutureOrder(string OrderID, string accid)
//    {
//        foreach (Order order in this.GetFutureOrders(accid))
//        {
//            if (order.OrderSysID == OrderID)
//            {
//                return order;
//            }
//        }
//        this.Print("$查询期货委托错误:GetFutureOrder(" + OrderID + ") = null ");
//        return null;
//    }

//    public Order GetFutureOrderByTrade(Trade trade)
//    {
//        if ((trade != null) && (trade.OrderSysID != ""))
//        {
//            return this.GetFutureOrder(trade.OrderSysID, trade.InvestorID);
//        }
//        return null;
//    }

//    public OrderSeries GetFutureOrders()
//    {
//        return this._fuction.GetFutureOrders(0);
//    }

//    public OrderSeries GetFutureOrders(int idx)
//    {
//        return this._fuction.GetFutureOrders(idx);
//    }

//    public OrderSeries GetFutureOrders(string accid)
//    {
//        return this._fuction.GetFutureOrders(accid);
//    }

//    public PositionSeries GetFuturePositions()
//    {
//        return this._fuction.GetFuturePositions(0);
//    }

//    public PositionSeries GetFuturePositions(int idx)
//    {
//        return this._fuction.GetFuturePositions(idx);
//    }

//    public PositionSeries GetFuturePositions(string accid)
//    {
//        return this._fuction.GetFuturePositions(accid);
//    }

//    public TickSeries GetFutureTickBuffer()
//    {
//        return this._fuction.GetFutureTickBuffer();
//    }

//    public TradeSeries GetFutureTrades()
//    {
//        return this._fuction.GetFutureTrades(0);
//    }

//    public TradeSeries GetFutureTrades(int idx)
//    {
//        return this._fuction.GetFutureTrades(idx);
//    }

//    public TradeSeries GetFutureTrades(string accid)
//    {
//        return this._fuction.GetFutureTrades(accid);
//    }

//    public double GetHighestBidPrice()
//    {
//        return this.GetHighestBidPrice(this.DefaultFutureCode);
//    }

//    public double GetHighestBidPrice(string FutureCode)
//    {
//        return this.Fun.GetFutureBuyOrderHigh(FutureCode, 0);
//    }

//    public double GetHighestBidPrice(string FutureCode, int idx)
//    {
//        return this.Fun.GetFutureBuyOrderHigh(FutureCode, idx);
//    }

//    public double GetHighestBidPrice(string FutureCode, string accid)
//    {
//        return this.Fun.GetFutureBuyOrderHigh(FutureCode, accid);
//    }

//    public double GetLowestAskPrice()
//    {
//        return this.GetLowestAskPrice(this.DefaultFutureCode);
//    }

//    public double GetLowestAskPrice(string FutureCode)
//    {
//        return this.Fun.GetFutureSellOrderLow(FutureCode, 0);
//    }

//    public double GetLowestAskPrice(string FutureCode, int idx)
//    {
//        return this.Fun.GetFutureSellOrderLow(FutureCode, idx);
//    }

//    public double GetLowestAskPrice(string FutureCode, string accid)
//    {
//        return this.Fun.GetFutureSellOrderLow(FutureCode, accid);
//    }

//    public DateTime GetPreTradingDay(DateTime t)
//    {
//        if (this._fuction == null)
//        {
//            return DateTime.Now.AddDays(-1.0);
//        }
//        return this._fuction.GetPreTradingDay(t);
//    }

//    public DataSeries GetPriceBuffer()
//    {
//        return this._fuction.GetPriceBuffer();
//    }

//    public StockAccount GetStockAccount()
//    {
//        return this._fuction.GetStockAccount();
//    }

//    public BarSeries GetStockBarSeries(string StockCode, int Interval, EnumBarType bar, EnumRestoration restore, DateTime beginTime)
//    {
//        BarSeries series = new BarSeries();
//        if (bar == EnumBarType.Tick)
//        {
//            this.Print("GetFutureBarSeries为K线方法,不支持Tick");
//            return series;
//        }
//        if (!this.AllStocks.Contains(StockCode))
//        {
//            this.Print("GetStockBarSeries失败,没有订阅股票[" + StockCode + "]");
//            return series;
//        }
//        return this._fuction.GetStockBarSeries(StockCode, Interval, bar, restore, beginTime);
//    }

//    public BarSeries GetStockBarSeries(string StockCode, int Interval, EnumBarType bar, EnumRestoration restore, int MaxLength)
//    {
//        BarSeries series = new BarSeries();
//        if (bar == EnumBarType.Tick)
//        {
//            this.Print("GetFutureBarSeries为K线方法,不支持Tick");
//            return series;
//        }
//        if (!this.AllStocks.Contains(StockCode))
//        {
//            this.Print("GetStockBarSeries失败,没有订阅股票[" + StockCode + "]");
//            return series;
//        }
//        return this._fuction.GetStockBarSeries(StockCode, Interval, bar, restore, MaxLength);
//    }

//    public List<StockDivideItem> GetStockDivide(string StockCode, DateTime from, DateTime to)
//    {
//        return this._fuction.GetStockDivide(StockCode, from, to);
//    }

//    public OrderSeries GetStockOrders()
//    {
//        return this._fuction.GetStockOrders();
//    }

//    public PositionSeries GetStockPositions()
//    {
//        return this._fuction.GetStockPositions();
//    }

//    public TradeSeries GetStockTrades()
//    {
//        return this._fuction.GetStockTrades();
//    }

//    public List<DateTime> GetTradingDays()
//    {
//        if (this._fuction == null)
//        {
//            return null;
//        }
//        return this._fuction.GetTradingDays();
//    }

//    public virtual void Init()
//    {
//    }

//    public bool IsTradingDay(DateTime t)
//    {
//        if (this._fuction == null)
//        {
//            return false;
//        }
//        return this._fuction.IsTradingDay(t);
//    }

//    public double LastFuturePrice()
//    {
//        if (this.DefaultFuture != null)
//        {
//            return this.LastFuturePrice(this.DefaultFutureCode);
//        }
//        this.Print("没有订阅期货品种");
//        return double.NaN;
//    }

//    public double LastFuturePrice(string FutureCode)
//    {
//        Tick tick = this.LastFutureTick(FutureCode);
//        if ((tick != null) && (tick.LastPrice > 0.0))
//        {
//            return tick.LastPrice;
//        }
//        if (this.AllFutures.Contains(FutureCode))
//        {
//            Future future = this.AllFutures[FutureCode];
//            return future.PreClose;
//        }
//        this.Print("没有订阅[" + FutureCode + "]行情");
//        return double.NaN;
//    }

//    public Tick LastFutureTick()
//    {
//        if (this.DefaultFuture != null)
//        {
//            return this.LastFutureTick(this.DefaultFutureCode);
//        }
//        this.Print("没有订阅期货品种");
//        return null;
//    }

//    public Tick LastFutureTick(string FutureCode)
//    {
//        if ((this.AllFutures != null) && this.AllFutures.Contains(FutureCode))
//        {
//            return this.AllFutures[FutureCode].LastTick;
//        }
//        this.Print("没有订阅[" + FutureCode + "]行情");
//        return null;
//    }

//    public double LastStockPrice()
//    {
//        if (this.DefaultStock != null)
//        {
//            return this.LastStockPrice(this.DefaultStockCode);
//        }
//        this.Print("没有订阅股票品种");
//        return double.NaN;
//    }

//    public double LastStockPrice(string StockCode)
//    {
//        Tick tick = this.LastStockTick(StockCode);
//        if ((tick != null) && (tick.LastPrice > 0.0))
//        {
//            return tick.LastPrice;
//        }
//        if (this.AllStocks.Contains(StockCode))
//        {
//            Stock stock = this.AllStocks[StockCode];
//            return stock.PreClose;
//        }
//        this.Print("没有订阅[" + StockCode + "]行情");
//        return double.NaN;
//    }

//    public Tick LastStockTick()
//    {
//        if (this.DefaultStock != null)
//        {
//            return this.LastStockTick(this.DefaultStockCode);
//        }
//        this.Print("没有订阅股票品种");
//        return null;
//    }

//    public Tick LastStockTick(string StockCode)
//    {
//        if ((this.AllStocks != null) && this.AllStocks.Contains(StockCode))
//        {
//            return this.AllStocks[StockCode].LastTick;
//        }
//        this.Print("没有订阅[" + StockCode + "]行情");
//        return null;
//    }

//    public Order LimitOrder(int Qty, EnumBuySell direction, EnumOpenClose OpenorClose)
//    {
//        if (this.DefaultFuture != null)
//        {
//            if (this.DefaultFuture.LastPrice > 0.0)
//            {
//                return this.LimitOrder(this.DefaultFutureCode, Qty, this.DefaultFuture.LastPrice, direction, OpenorClose, 0);
//            }
//            this.Print("默认期货合约[" + this.DefaultFutureCode + "]的最新价错误=" + this.DefaultFuture.LastPrice.ToString() + "元");
//            return null;
//        }
//        this.Print("没有订阅期货合约");
//        return null;
//    }

//    public Order LimitOrder(int Qty, EnumBuySell direction, EnumOpenClose OpenorClose, int idx)
//    {
//        if (this.DefaultFuture != null)
//        {
//            if (this.DefaultFuture.LastPrice > 0.0)
//            {
//                return this.LimitOrder(this.DefaultFutureCode, Qty, this.DefaultFuture.LastPrice, direction, OpenorClose, idx);
//            }
//            this.Print("默认期货合约[" + this.DefaultFutureCode + "]的最新价错误=" + this.DefaultFuture.LastPrice.ToString() + "元");
//            return null;
//        }
//        this.Print("没有订阅期货合约");
//        return null;
//    }

//    public Order LimitOrder(int Qty, EnumBuySell direction, EnumOpenClose OpenorClose, string accid)
//    {
//        if (this.DefaultFuture != null)
//        {
//            if (this.DefaultFuture.LastPrice > 0.0)
//            {
//                return this.LimitOrder(this.DefaultFutureCode, Qty, this.DefaultFuture.LastPrice, direction, OpenorClose, accid);
//            }
//            this.Print("默认期货合约[" + this.DefaultFutureCode + "]的最新价错误=" + this.DefaultFuture.LastPrice.ToString() + "元");
//            return null;
//        }
//        this.Print("没有订阅期货合约");
//        return null;
//    }

//    public Order LimitOrder(int Qty, double LimitPrice, EnumBuySell direction, EnumOpenClose OpenorClose)
//    {
//        if (this.DefaultFuture != null)
//        {
//            return this.LimitOrder(this.DefaultFutureCode, Qty, LimitPrice, direction, OpenorClose, 0);
//        }
//        this.Print("没有订阅期货品种");
//        return null;
//    }

//    public Order LimitOrder(int Qty, double LimitPrice, EnumBuySell direction, EnumOpenClose OpenorClose, int idx)
//    {
//        if (this.DefaultFuture != null)
//        {
//            return this.LimitOrder(this.DefaultFutureCode, Qty, LimitPrice, direction, OpenorClose, idx);
//        }
//        this.Print("没有订阅期货品种");
//        return null;
//    }

//    public Order LimitOrder(int Qty, double LimitPrice, EnumBuySell direction, EnumOpenClose OpenorClose, string accid)
//    {
//        if (this.DefaultFuture != null)
//        {
//            return this.LimitOrder(this.DefaultFutureCode, Qty, LimitPrice, direction, OpenorClose, accid);
//        }
//        this.Print("没有订阅期货品种");
//        return null;
//    }

//    public Order LimitOrder(int Qty, double BasePrice, int Jump, EnumBuySell direction, EnumOpenClose OpenorClose)
//    {
//        if (this.DefaultFuture != null)
//        {
//            return this.LimitOrder(this.DefaultFutureCode, Qty, BasePrice, Jump, direction, OpenorClose, 0);
//        }
//        this.Print("没有订阅期货合约");
//        return null;
//    }

//    public Order LimitOrder(string FutureCode, int Qty, double LimitedPrice, EnumBuySell Direction, EnumOpenClose OpenorClose)
//    {
//        return this.LimitOrder(FutureCode, Qty, LimitedPrice, Direction, OpenorClose, EnumHedgeFlag.Speculation, 0);
//    }

//    public Order LimitOrder(int Qty, double BasePrice, int Jump, EnumBuySell direction, EnumOpenClose OpenorClose, int idx)
//    {
//        if (this.DefaultFuture != null)
//        {
//            return this.LimitOrder(this.DefaultFutureCode, Qty, BasePrice, Jump, direction, OpenorClose, idx);
//        }
//        this.Print("没有订阅期货合约");
//        return null;
//    }

//    public Order LimitOrder(int Qty, double BasePrice, int Jump, EnumBuySell direction, EnumOpenClose OpenorClose, string accid)
//    {
//        if (this.DefaultFuture != null)
//        {
//            return this.LimitOrder(this.DefaultFutureCode, Qty, BasePrice, Jump, direction, OpenorClose, accid);
//        }
//        this.Print("没有订阅期货合约");
//        return null;
//    }

//    public Order LimitOrder(string FutureCode, int Qty, double LimitedPrice, EnumBuySell Direction, EnumOpenClose OpenorClose, EnumHedgeFlag HedgeFlag)
//    {
//        if (Qty <= 0)
//        {
//            this.Print("$期货合约委托数量不能小于等于0!");
//            return null;
//        }
//        Order order = this._fuction.SendLimitFutureOrder(FutureCode, Qty, LimitedPrice, Direction, OpenorClose, HedgeFlag, 0);
//        string msg = "$期货委托:" + OpenorClose.ToString() + Direction.ToString() + Qty.ToString() + "手[" + FutureCode + "]限价" + LimitedPrice.ToString() + "元@" + this.Now.ToString("HH:mm:ss.fff");
//        this.Print(msg);
//        return order;
//    }

//    public Order LimitOrder(string FutureCode, int Qty, double LimitedPrice, EnumBuySell Direction, EnumOpenClose OpenorClose, int idx)
//    {
//        return this.LimitOrder(FutureCode, Qty, LimitedPrice, Direction, OpenorClose, EnumHedgeFlag.Speculation, idx);
//    }

//    public Order LimitOrder(string FutureCode, int Qty, double LimitedPrice, EnumBuySell Direction, EnumOpenClose OpenorClose, string accid)
//    {
//        return this.LimitOrder(FutureCode, Qty, LimitedPrice, Direction, OpenorClose, EnumHedgeFlag.Speculation, accid);
//    }

//    public Order LimitOrder(string FutureCode, int Qty, double basePrice, int Jump, EnumBuySell direction, EnumOpenClose OpenorClose)
//    {
//        return this.LimitOrder(FutureCode, Qty, basePrice, Jump, direction, OpenorClose, 0);
//    }

//    public Order LimitOrder(string FutureCode, int Qty, double LimitedPrice, EnumBuySell Direction, EnumOpenClose OpenorClose, EnumHedgeFlag HedgeFlag, int idx)
//    {
//        if (Qty <= 0)
//        {
//            this.Print("$期货合约委托数量不能小于等于0!");
//            return null;
//        }
//        Order order = this._fuction.SendLimitFutureOrder(FutureCode, Qty, LimitedPrice, Direction, OpenorClose, HedgeFlag, idx);
//        string msg = "$期货委托:" + OpenorClose.ToString() + Direction.ToString() + Qty.ToString() + "手[" + FutureCode + "]限价" + LimitedPrice.ToString() + "元@" + this.Now.ToString("HH:mm:ss.fff");
//        this.Print(msg);
//        return order;
//    }

//    public Order LimitOrder(string FutureCode, int Qty, double LimitedPrice, EnumBuySell Direction, EnumOpenClose OpenorClose, EnumHedgeFlag HedgeFlag, string accid)
//    {
//        if (Qty <= 0)
//        {
//            this.Print("$期货合约委托数量不能小于等于0!");
//            return null;
//        }
//        Order order = this._fuction.SendLimitFutureOrder(FutureCode, Qty, LimitedPrice, Direction, OpenorClose, HedgeFlag, accid);
//        string msg = "$期货委托:" + OpenorClose.ToString() + Direction.ToString() + Qty.ToString() + "手[" + FutureCode + "]限价" + LimitedPrice.ToString() + "元@" + this.Now.ToString("HH:mm:ss.fff");
//        this.Print(msg);
//        return order;
//    }

//    public Order LimitOrder(string FutureCode, int Qty, double basePrice, int Jump, EnumBuySell direction, EnumOpenClose OpenorClose, int idx)
//    {
//        if (((this.AllFutures != null) && (this.AllFutures.Count > 0)) && this.AllFutures.Contains(FutureCode))
//        {
//            Future future = this.AllFutures[FutureCode];
//            if (future.PriceTick > 0.0)
//            {
//                double priceTick = future.PriceTick;
//                if (basePrice > 0.0)
//                {
//                    double limitedPrice = this.TrimFuturePrice(future, basePrice + (Jump * priceTick));
//                    return this.LimitOrder(FutureCode, Qty, limitedPrice, direction, OpenorClose, EnumHedgeFlag.Speculation, idx);
//                }
//                this.Print("$期货品种[" + FutureCode + "]基准价格异常=" + basePrice.ToString());
//                return null;
//            }
//            this.Print("$期货品种[" + FutureCode + "]最小价格单位异常=" + future.PriceTick.ToString());
//            return null;
//        }
//        this.Print("$没有订阅期货品种[" + FutureCode + "]");
//        return null;
//    }

//    public Order LimitOrder(string FutureCode, int Qty, double basePrice, int Jump, EnumBuySell direction, EnumOpenClose OpenorClose, string accid)
//    {
//        if (((this.AllFutures != null) && (this.AllFutures.Count > 0)) && this.AllFutures.Contains(FutureCode))
//        {
//            Future future = this.AllFutures[FutureCode];
//            if (future.PriceTick > 0.0)
//            {
//                double priceTick = future.PriceTick;
//                if (basePrice > 0.0)
//                {
//                    double limitedPrice = this.TrimFuturePrice(future, basePrice + (Jump * priceTick));
//                    return this.LimitOrder(FutureCode, Qty, limitedPrice, direction, OpenorClose, EnumHedgeFlag.Speculation, accid);
//                }
//                this.Print("$期货品种[" + FutureCode + "]基准价格异常=" + basePrice.ToString());
//                return null;
//            }
//            this.Print("$期货品种[" + FutureCode + "]最小价格单位异常=" + future.PriceTick.ToString());
//            return null;
//        }
//        this.Print("$没有订阅期货品种[" + FutureCode + "]");
//        return null;
//    }

//    public Order MarketOrder(int Qty, EnumBuySell BuyorSell, EnumOpenClose openorclose)
//    {
//        return this.MarketOrder(this.DefaultFutureCode, Qty, BuyorSell, openorclose);
//    }

//    public Order MarketOrder(string FutureCode, int Qty, EnumBuySell BuyorSell, EnumOpenClose openorclose)
//    {
//        return this._fuction.SendMarketFutureOrder(FutureCode, Qty, BuyorSell, openorclose, EnumHedgeFlag.Speculation, 0);
//    }

//    public Order MarketOrder(string FutureCode, int Qty, EnumBuySell BuyorSell, EnumOpenClose openorclose, EnumHedgeFlag hedgeFlag)
//    {
//        return this._fuction.SendMarketFutureOrder(FutureCode, Qty, BuyorSell, openorclose, hedgeFlag, 0);
//    }

//    public int MarketPosition()
//    {
//        return this.MarketPosition(this.DefaultFutureCode, 0);
//    }

//    public int MarketPosition(string FutureCode)
//    {
//        return this.MarketPosition(FutureCode, 0);
//    }

//    public int MarketPosition(string FutureCode, int idx)
//    {
//        if (FutureCode == "")
//        {
//            this.Print("$查询MarketPosition时，期货品种代码不能为空");
//            return 0;
//        }
//        PositionSeries futurePositions = this.GetFuturePositions(idx);
//        int num = 0;
//        if ((futurePositions != null) && (futurePositions.Count > 0))
//        {
//            foreach (Position position in futurePositions)
//            {
//                if (position.InstrumentID == FutureCode)
//                {
//                    if (position.PosiDirection == EnumPositionDirection.多头)
//                    {
//                        num += position.Volumn;
//                    }
//                    else if (position.PosiDirection == EnumPositionDirection.空头)
//                    {
//                        num -= position.Volumn;
//                    }
//                }
//            }
//        }
//        return num;
//    }

//    public int MarketPosition(string FutureCode, string accid)
//    {
//        if (FutureCode == "")
//        {
//            return 0;
//        }
//        PositionSeries futurePositions = this.GetFuturePositions(accid);
//        int num = 0;
//        if ((futurePositions != null) && (futurePositions.Count > 0))
//        {
//            foreach (Position position in futurePositions)
//            {
//                if (position.InstrumentID == FutureCode)
//                {
//                    if (position.PosiDirection == EnumPositionDirection.多头)
//                    {
//                        num += position.Volumn;
//                    }
//                    else if (position.PosiDirection == EnumPositionDirection.空头)
//                    {
//                        num -= position.Volumn;
//                    }
//                }
//            }
//        }
//        return num;
//    }

//    public void ModifyFutureAccountPassWord(string NewPassWord)
//    {
//    }

//    public void ModifyFutureAccountPassWord(int idx, string NewPassWord)
//    {
//    }

//    public void ModifyFutureAccountPassWord(string accid, string NewPassWord)
//    {
//    }

//    public void ModifyFutureMoney(double money)
//    {
//        if (this._fuction != null)
//        {
//            this._fuction.ModifyFutureMoney(money);
//        }
//    }

//    public void ModifyStockMoney(double money)
//    {
//        if (this._fuction != null)
//        {
//            this._fuction.ModifyStockMoney(money);
//        }
//    }

//    public virtual void OnBar(Bar bar)
//    {
//    }

//    public virtual void OnCancelOrderFailed(Order order, string msg)
//    {
//    }

//    public virtual void OnOrder(Order order)
//    {
//    }

//    public virtual void OnOrderCanceled(Order order)
//    {
//    }

//    public virtual void OnOrderRejected(Order order)
//    {
//    }

//    public virtual void OnSysWarning(SysWarningEventArg arg)
//    {
//    }

//    public virtual void OnTick(Tick tick)
//    {
//    }

//    public virtual void OnTrade(Trade trade)
//    {
//    }

//    public void PlaySound(EnumSound sound)
//    {
//        if (this._fuction != null)
//        {
//            this._fuction.PlaySound(sound);
//        }
//    }

//    public void PlotSignal(EnumBuySell direction, EnumOpenClose oc)
//    {
//        this.PlotSignal(this.Now, direction, oc);
//    }

//    public void PlotSignal(DateTime t, EnumBuySell direction, EnumOpenClose oc)
//    {
//        this.PlotSignal(this.DefaultFutureCode, this.DefaultFuture.LastPrice, t, direction, oc, EnumMarket.期货);
//    }

//    public void PlotSignal(string InsID, double price, DateTime t, EnumBuySell direction, EnumOpenClose oc, EnumMarket market)
//    {
//    }

//    public void PlotString(string str)
//    {
//        this.PlotString(str, this.DefaultFuture.LastPrice, this.Now);
//    }

//    public void PlotString(string str, double price, DateTime t)
//    {
//    }

//    public void Print(string msg)
//    {
//        if (this._fuction != null)
//        {
//            this._fuction.Print(msg);
//        }
//    }

//    public void Probe(EnumBuySell direction, double life, int capacity)
//    {
//        this.Probe(this.DefaultFutureCode, direction, EnumMarket.期货, life, capacity);
//    }

//    public void Probe(string insID, EnumBuySell direction, EnumMarket market, double life, int capacity)
//    {
//        if (this._fuction != null)
//        {
//            this._fuction.Probe(insID, direction, market, life, capacity);
//        }
//    }

//    public EnumBuySell Reverse(EnumBuySell Direction)
//    {
//        if (Direction == EnumBuySell.买入)
//        {
//            return EnumBuySell.卖出;
//        }
//        return EnumBuySell.买入;
//    }

//    public Order SellStock(string StockCode, int Amount, double Price)
//    {
//        if (Amount <= 0)
//        {
//            this.Print("$卖出" + StockCode + "股数不能小于等于0!");
//            return null;
//        }
//        Order order = this._fuction.SellStock(StockCode, Amount, Price);
//        this.Print("$卖出" + Amount.ToString() + "股[" + StockCode + "]限价" + Price.ToString() + "元@" + this.Now.ToString("HH:mm:ss.fff"));
//        return order;
//    }

//    public void SetDict(string key, string value)
//    {
//        this._fuction.SetDict(key, value);
//    }

//    public void ShowMessage(string message)
//    {
//        if (this._fuction != null)
//        {
//            this.Print("$人工确认提示信息[" + message + "]");
//            this._fuction.ShowMessage(message);
//        }
//    }

//    public void Stop(string message)
//    {
//        this.Print("调用策略退出的Exit方法");
//        this.Exit();
//        this.Print("停止策略(" + message + ")");
//        throw new Exception(message);
//    }

//    public double TotalMinutes(EnumExchange exchange)
//    {
//        return Math.Round(this.TotalTimeSpan(exchange).TotalMinutes, 2);
//    }

//    public double TotalMinutes(Exchange exchange)
//    {
//        return Math.Round(this.TotalTimeSpan(exchange).TotalMinutes, 2);
//    }

//    public double TotalSeconds(EnumExchange exchange)
//    {
//        return Math.Round(this.TotalTimeSpan(exchange).TotalSeconds, 2);
//    }

//    public double TotalSeconds(Exchange exchange)
//    {
//        return Math.Round(this.TotalTimeSpan(exchange).TotalSeconds, 2);
//    }

//    public TimeSpan TotalTimeSpan(EnumExchange exchange)
//    {
//        return this.TotalTimeSpan(this.GetExchange(exchange));
//    }

//    public TimeSpan TotalTimeSpan(Exchange exchange)
//    {
//        return this._fuction.TotalTimeSpan(exchange);
//    }

//    public double TrimFuturePrice(double orderPrice)
//    {
//        if (this.DefaultFuture != null)
//        {
//            return this.TrimFuturePrice(this.DefaultFuture, orderPrice);
//        }
//        this.Print("$整理价格TrimFuturePrice时出错:DefaultFuture=null");
//        return orderPrice;
//    }

//    public double TrimFuturePrice(Future future, double orderPrice)
//    {
//        double num = orderPrice;
//        if (future != null)
//        {
//            return FutureHelper.TrimFuturePrice(future, orderPrice);
//        }
//        this.Print("$整理价格TrimFuturePrice时出错:future=null");
//        return num;
//    }

//    public void Wait(int T)
//    {
//        this.Print("休眠[" + T.ToString() + "]毫秒,@Now=" + this.Now.ToString());
//        this._fuction.Wait(T);
//    }

//    // Properties
//    public FutureSeries AllFutures
//    {
//        get
//        {
//            return this._fuction.AllFutures;
//        }
//    }

//    public StockSeries AllStocks
//    {
//        get
//        {
//            return this._fuction.AllStocks;
//        }
//    }

//    public int Day
//    {
//        get
//        {
//            return this._fuction.Now.Day;
//        }
//    }

//    public Future DefaultFuture
//    {
//        get
//        {
//            if ((this.AllFutures != null) && (this.AllFutures.Count > 0))
//            {
//                return this.AllFutures[0];
//            }
//            return null;
//        }
//    }

//    public string DefaultFutureCode
//    {
//        get
//        {
//            if (this.DefaultFuture != null)
//            {
//                return this.DefaultFuture.ID;
//            }
//            return "";
//        }
//    }

//    public Stock DefaultStock
//    {
//        get
//        {
//            if ((this.AllStocks != null) && (this.AllStocks.Count > 0))
//            {
//                return this.AllStocks[0];
//            }
//            return null;
//        }
//    }

//    public string DefaultStockCode
//    {
//        get
//        {
//            if (this.DefaultStock != null)
//            {
//                return this.DefaultStock.StockCode;
//            }
//            return "";
//        }
//    }

//    public IFunction Fun
//    {
//        get
//        {
//            return this._fuction;
//        }
//        set
//        {
//            this._fuction = value;
//        }
//    }

//    public int FutureAccountCount
//    {
//        get
//        {
//            return this._fuction.FutureAccountCount;
//        }
//    }

//    public int Month
//    {
//        get
//        {
//            return this._fuction.Now.Month;
//        }
//    }

//    public FutureAccount MyFutureAccount
//    {
//        get
//        {
//            return this._fuction.MyFutureAccount;
//        }
//    }

//    public PositionSeries MyFuturePositions
//    {
//        get
//        {
//            return this._fuction.MyFuturePositions;
//        }
//    }

//    public StockAccount MyStockAccount
//    {
//        get
//        {
//            return this._fuction.MyStockAccount;
//        }
//    }

//    public PositionSeries MyStockPositions
//    {
//        get
//        {
//            return this._fuction.MyStockPositions;
//        }
//    }

//    public DateTime Now
//    {
//        get
//        {
//            return this._fuction.Now;
//        }
//    }

//    public string TriggerInstrument
//    {
//        get
//        {
//            return this._fuction.TriggerInstrument;
//        }
//    }

//    public int Year
//    {
//        get
//        {
//            return this._fuction.Now.Year;
//        }
//    }
//}

 
