using System;
using System.Data;


namespace tslight
{

    //================================================================================
	#region DataSet_tslight2
	//--------------------------------------------------------------------------------
	public class DataSet_tslight2 : DataSet
	{
        public DataTable_quotation t_quotation;	
		public DataTable_timeframe t_timeframe;	
		public DataTable_candle t_candle;	
        
		
		//--------------------------------------------------------------------------------
		public DataSet_tslight2():
			base()
		{
            t_quotation = new DataTable_quotation();
			t_timeframe = new DataTable_timeframe();
			t_candle = new DataTable_candle();
            
		}
		//--------------------------------------------------------------------------------
	}
	//--------------------------------------------------------------------------------
	#endregion
    //================================================================================
    #region Data_quotationquotation
    //--------------------------------------------------------------------------------
	public class DataTable_quotation : DataTable
	{
        public DataColumn quotation_id;
        public DataColumn quotation_code;
        public DataColumn quotation_open;
        public DataColumn quotation_biddepth;
        public DataColumn quotation_numbids;
        public DataColumn quotation_last;
		//--------------------------------------------------------------------------------
        public DataTable_quotation()
		{
            TableName = "t_quotation";
			BeginInit();
			InitClass();
			EndInit();
		}
		//--------------------------------------------------------------------------------
		public int Count
		{
			get { return Rows.Count; }
		}
		//--------------------------------------------------------------------------------
        public void Add_Row(DataRow_quotation row)
		{
			Rows.Add(row);
		}
        //--------------------------------------------------------------------------------
        public void Remove_Row(DataRow_quotation row)
		{
			Rows.Remove(row);
		}
        //--------------------------------------------------------------------------------
        public DataRow_quotation Add_Row(int quotation_id, string quotation_code, double quotation_open, int quotation_biddepth, int quotation_numbids, double quotation_last)
		{
            DataRow_quotation row = (DataRow_quotation)NewRow();
			object[] aValues = new object[]
			{
				quotation_id,  quotation_code,  quotation_open,  quotation_biddepth,  quotation_numbids,  quotation_last
			};
			row.ItemArray = aValues;
			Rows.Add(row);
			return row;
		}
		//--------------------------------------------------------------------------------
        public DataRow_quotation New_Row()
		{
            return (DataRow_quotation)NewRow();
		}
		//--------------------------------------------------------------------------------
		protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder)
		{
            return new DataRow_quotation(builder);
		}
		//--------------------------------------------------------------------------------
		public DataRow FindByID(uint id)
		{
            return (DataRow_quotation)Rows.Find(new object[] { id });
		}
		//--------------------------------------------------------------------------------
		internal void InitVars()
		{
            quotation_id = Columns["quotation_id"];
            quotation_code = Columns["quotation_code"];
            quotation_open = Columns["quotation_open"];
            quotation_biddepth = Columns["quotation_biddepth"];
            quotation_numbids = Columns["quotation_numbids"];
            quotation_last = Columns["quotation_last"];
		}
		//--------------------------------------------------------------------------------
		internal void InitClass()
		{
            quotation_id = new DataColumn("quotation_id", typeof(int), null, MappingType.Element);
            Columns.Add(quotation_id);
            quotation_code = new DataColumn("quotation_code ", typeof(string), null, MappingType.Element);
            Columns.Add(quotation_code);
            quotation_open = new DataColumn("quotation_open", typeof(string), null, MappingType.Element);
            Columns.Add(quotation_open);
            quotation_biddepth = new DataColumn("quotation_biddepth", typeof(int), null, MappingType.Element);
            Columns.Add(quotation_biddepth);
            quotation_numbids = new DataColumn("quotation_numbids", typeof(string), null, MappingType.Element);
            Columns.Add(quotation_numbids);
            quotation_last = new DataColumn("quotation_last", typeof(string), null, MappingType.Element);
            Columns.Add(quotation_last);

            PrimaryKey = new DataColumn[] { quotation_id };
            quotation_code.MaxLength = 50;
            quotation_last.MaxLength = 50;
		}
		//--------------------------------------------------------------------------------
		protected override Type GetRowType()
		{
            return typeof(DataRow_quotation);
		}
		//--------------------------------------------------------------------------------
        public DataRow_quotation this[int index]
		{
            get { return (DataRow_quotation)Rows[index]; }
		}
		//--------------------------------------------------------------------------------
	}
	
	public partial class DataRow_quotation : global::System.Data.DataRow
	{
		private DataTable_quotation table;
		
		//--------------------------------------------------------------------------------
        internal DataRow_quotation(global::System.Data.DataRowBuilder rb) :
			base(rb)
		{
            table = (DataTable_quotation)Table;
		}
		//--------------------------------------------------------------------------------
        public int quotation_id
		{
            get { return (int)this[table.quotation_id]; }
            set { this[table.quotation_id] = value; }
		}
        //-------------------------------------------------------------------------------
        public string quotation_code
		{
            get { return (string)this[table.quotation_code]; }
            set { this[table.quotation_code] = value; }
		}
		//--------------------------------------------------------------------------------
        public double quotation_open
		{
            get { return (double)this[table.quotation_open]; }
            set { this[table.quotation_open] = value; }
		}
		//--------------------------------------------------------------------------------
        public int quotation_biddepth
		{
            get { return (int)this[table.quotation_biddepth]; }
            set { this[table.quotation_biddepth] = value; }
		}

        public int quotation_numbids
        {
            get { return (int)this[table.quotation_numbids]; }
            set { this[table.quotation_numbids] = value; }
        }
        public double quotation_last
        {
            get { return (double)this[table.quotation_last]; }
            set { this[table.quotation_last] = value; }
        }


		//--------------------------------------------------------------------------------
	}
	#endregion // Data_quation
	//================================================================================
	#region Data_timeframe
	//--------------------------------------------------------------------------------
	public class DataTable_timeframe2 : DataTable
	{
		public DataColumn timeframe_id;
		public DataColumn timeframe_length;
		public DataColumn timeframe_name;
		
		//--------------------------------------------------------------------------------
		public DataTable_timeframe2()
		{
			TableName = "t_timeframe";
			BeginInit();
			InitClass();
			EndInit();
		}
		//--------------------------------------------------------------------------------
		public int Count
		{
			get { return Rows.Count; }
		}
		//--------------------------------------------------------------------------------
		public void Add_Row(DataRow_timeframe row)
		{
			Rows.Add(row);
		}
		//--------------------------------------------------------------------------------
		public void Remove_Row(DataRow_timeframe row)
		{
			Rows.Remove(row);
		}
		//--------------------------------------------------------------------------------
		public DataRow_timeframe Add_Row(int timeframe_id, int timeframe_length, string timeframe_name)
		{
			DataRow_timeframe row = (DataRow_timeframe)NewRow();
			object[] aValues = new object[]
			{
				timeframe_id, timeframe_length, timeframe_name
			};
			row.ItemArray = aValues;
			Rows.Add(row);
			return row;
		}
		//--------------------------------------------------------------------------------
		public DataRow_timeframe New_Row()
		{
			return (DataRow_timeframe)NewRow();
		}
		//--------------------------------------------------------------------------------
		protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder)
		{
			return new DataRow_timeframe(builder);
		}
		//--------------------------------------------------------------------------------
		public DataRow FindByID(uint id)
		{
			return (DataRow_timeframe)Rows.Find(new object[] {id} );
		}
		//--------------------------------------------------------------------------------
		internal void InitVars()
		{
			timeframe_id = Columns["timeframe_id"];
			timeframe_length = Columns["timeframe_length"];
			timeframe_name = Columns["timeframe_name"];
		}
		//--------------------------------------------------------------------------------
		internal void InitClass()
		{
			timeframe_id = new DataColumn("timeframe_id", typeof(int), null, MappingType.Element);
			Columns.Add(timeframe_id);
			timeframe_length = new DataColumn("timeframe_length", typeof(int), null, MappingType.Element);
			Columns.Add(timeframe_length);
			timeframe_name = new DataColumn("timeframe_name", typeof(string), null, MappingType.Element);
			Columns.Add(timeframe_name);
			
			PrimaryKey = new DataColumn[] { timeframe_id };
			timeframe_name.MaxLength = 50;
		}
		//--------------------------------------------------------------------------------
		protected override Type GetRowType()
		{
			return typeof(DataRow_timeframe);
		}
		//--------------------------------------------------------------------------------
		public DataRow_timeframe this[int index]
		{
			get { return (DataRow_timeframe)Rows[index]; }
		}
		//--------------------------------------------------------------------------------
	}

	public partial class DataRow_timeframe2 : global::System.Data.DataRow
	{
		private DataTable_timeframe table;
		
		//--------------------------------------------------------------------------------
		internal DataRow_timeframe2(global::System.Data.DataRowBuilder rb):
			base(rb)
		{
			table = (DataTable_timeframe)Table;
		}
		//--------------------------------------------------------------------------------
		public int timeframe_id
		{
			get { return (int)this[table.timeframe_id]; }
			set { this[table.timeframe_id] = value; }
		}
		//--------------------------------------------------------------------------------
		public int timeframe_length
		{
			get { return (int)this[table.timeframe_length]; }
			set { this[table.timeframe_length] = value; }
		}
		//--------------------------------------------------------------------------------
		public string timeframe_name
		{
			get { return (string)this[table.timeframe_name]; }
			set { this[table.timeframe_name] = value; }
		}
		//--------------------------------------------------------------------------------
	}
	#endregion // Data_timeframe
	//================================================================================
	#region Data_candle
	//--------------------------------------------------------------------------------
	public class DataTable_candle2 : DataTable
	{
		public DataColumn date;
		public DataColumn open;
		public DataColumn high;
		public DataColumn low;
		public DataColumn close;
		public DataColumn volume;
		
		//--------------------------------------------------------------------------------
		public DataTable_candle2()
		{
			TableName = "t_candle";
			BeginInit();
			InitClass();
			EndInit();
		}
		//--------------------------------------------------------------------------------
		public int Count
		{
			get { return Rows.Count; }
		}
		//--------------------------------------------------------------------------------
		public void Add_Row(DataRow_candle2 row)
		{
			Rows.Add(row);
		}
		//--------------------------------------------------------------------------------
		public void Remove_Row(DataRow_candle2 row)
		{
			Rows.Remove(row);
		}
		//--------------------------------------------------------------------------------
		public DataRow_candle2 Add_Row(DateTime date, double open, double high, double low, double close, int volume)
		{
			DataRow_candle2 row = (DataRow_candle2)NewRow();
			object[] aValues = new object[]
			{
				date, open, high, low, close, volume
			};
			row.ItemArray = aValues;
			Rows.Add(row);
			return row;
		}
		//--------------------------------------------------------------------------------
		public DataRow_candle2 New_Row()
		{
			return (DataRow_candle2)NewRow();
		}
		//--------------------------------------------------------------------------------
		protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder)
		{
			return new DataRow_candle2(builder);
		}
		//--------------------------------------------------------------------------------
		public DataRow FindByDT(DateTime dt)
		{
			return (DataRow_candle2)Rows.Find(new object[] {dt} );
		}
		//--------------------------------------------------------------------------------
		internal void InitVars()
		{
			date = Columns["date"];
			open = Columns["open"];
			high = Columns["high"];
			low = Columns["low"];
			close = Columns["close"];
			volume = Columns["volume"];
		}
		//--------------------------------------------------------------------------------
		internal void InitClass()
		{
			date = new DataColumn("date", typeof(DateTime), null, MappingType.Element);
			Columns.Add(date);
			open = new DataColumn("open", typeof(double), null, MappingType.Element);
			Columns.Add(open);
			high = new DataColumn("high", typeof(double), null, MappingType.Element);
			Columns.Add(high);
			low = new DataColumn("low", typeof(double), null, MappingType.Element);
			Columns.Add(low);
			close = new DataColumn("close", typeof(double), null, MappingType.Element);
			Columns.Add(close);
			volume = new DataColumn("volume", typeof(int), null, MappingType.Element);
			Columns.Add(volume);
			
			//PrimaryKey = new DataColumn[] { date };
		}
		//--------------------------------------------------------------------------------
		protected override Type GetRowType()
		{
			return typeof(DataRow_candle2);
		}
		//--------------------------------------------------------------------------------
		public DataRow_candle2 this[int index]
		{
			get { return (DataRow_candle2)Rows[index]; }
		}
		//--------------------------------------------------------------------------------
	}

    public partial class DataRow_candle2: global::System.Data.DataRow
	{
		private DataTable_candle table;
		
		//--------------------------------------------------------------------------------
		internal DataRow_candle2(global::System.Data.DataRowBuilder rb):
			base(rb)
		{
			table = (DataTable_candle)Table;
		}
		//--------------------------------------------------------------------------------
		public DateTime date
		{
			get { return (DateTime)this[table.date]; }
			set { this[table.date] = value; }
		}
		//--------------------------------------------------------------------------------
		public double open
		{
			get { return (double)this[table.open]; }
			set { this[table.open] = value; }
		}
		//--------------------------------------------------------------------------------
		public double high
		{
			get { return (double)this[table.high]; }
			set { this[table.high] = value; }
		}
		//--------------------------------------------------------------------------------
		public double low
		{
			get { return (double)this[table.low]; }
			set { this[table.low] = value; }
		}
		//--------------------------------------------------------------------------------
		public double close
		{
			get { return (double)this[table.close]; }
			set { this[table.close] = value; }
		}
		//--------------------------------------------------------------------------------
		public int volume
		{
			get { return (int)this[table.volume]; }
			set { this[table.volume] = value; }
		}
		//--------------------------------------------------------------------------------
	}
	#endregion // Data_candle
	//================================================================================

}
