using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Test_Highcharts
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GVshow0.DataSource = Session["dtHD_Create_MartandSupplier1"];
            GVshow0.DataBind();
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            Render_Chart();
            LBtypeselect.Text = "Booking New Cars";
            CBoutlet.Value = "ทั้งหมด";
            CByear.Value = "2019";

//            string sqlquerycw = String.Format(@"SELECT        dbo.MS_SD_BOOKING.DEALER_CODE, dbo.MS_SD_BOOKING.BOOKING_NO, dbo.MS_SD_BOOKING.BOOKING_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.MODEL_YEAR, 
//                         dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.BOOK_CUSTOMER_NO, dbo.MS_SD_BOOKING.BOOK_CUS_SIR_NAME, 
//                         dbo.MS_SD_BOOKING.BOOK_CUS_FIRST_NAME, dbo.MS_SD_BOOKING.BOOK_CUS_LAST_NAME, dbo.MS_SD_BOOKING.STAFF_CODE, dbo.MS_SD_BOOKING.STAFF_FIRST_NAME, 
//                         dbo.MS_SD_BOOKING.STAFF_LAST_NAME, ' -> ' AS Vehicle, dbo.MS_SD_BOOKING.FRAME_NO, dbo.MS_SD_BOOKING.ALLOCATION_DATE, dbo.MS_SD_BOOKING.SERIES_NAME AS Expr1, 
//                         dbo.MS_SD_BOOKING.SERIES_NAME + N' ' + dbo.MS_SD_BOOKING.MODEL_GRADE AS Models_Name, dbo.MS_SD_BOOKING.MODEL_CC, dbo.MS_SD_BOOKING.MODEL_GRADE AS Expr2, 
//                         dbo.MS_SD_BOOKING.MODEL_COLOR AS Expr3, dbo.MS_SD_BOOKING.MODEL_YEAR AS Expr4, dbo.MS_SD_BOOKING.MTOC, dbo.MS_SD_BOOKING.CAR_PRICE, dbo.MS_SD_BOOKING.DISCOUNT, 
//                         dbo.MS_SD_BOOKING.PRICE_AFTER_DISCOUNT, dbo.MS_SD_BOOKING.VAT, dbo.MS_SD_BOOKING.TOTAL, dbo.MS_SD_BOOKING.DEPOSIT
//FROM            dbo.MS_SD_BOOKING INNER JOIN
//                         dbo.MS_SD_BOOKING_TYPE ON dbo.MS_SD_BOOKING.BOOKING_STATUS = dbo.MS_SD_BOOKING_TYPE.BOOKING_STATUS
//WHERE        (YEAR(dbo.MS_SD_BOOKING.BOOKING_DATE) = '2019')
//GROUP BY dbo.MS_SD_BOOKING.DEALER_CODE, dbo.MS_SD_BOOKING.BOOKING_NO, dbo.MS_SD_BOOKING.BOOKING_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.MODEL_YEAR, 
//                         dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.BOOK_CUSTOMER_NO, dbo.MS_SD_BOOKING.BOOK_CUS_SIR_NAME, 
//                         dbo.MS_SD_BOOKING.BOOK_CUS_FIRST_NAME, dbo.MS_SD_BOOKING.BOOK_CUS_LAST_NAME, dbo.MS_SD_BOOKING.STAFF_CODE, dbo.MS_SD_BOOKING.STAFF_FIRST_NAME, 
//                         dbo.MS_SD_BOOKING.STAFF_LAST_NAME, dbo.MS_SD_BOOKING.FRAME_NO, dbo.MS_SD_BOOKING.ALLOCATION_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.SERIES_NAME, 
//                         dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_CC, dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.MODEL_YEAR, dbo.MS_SD_BOOKING.MTOC, 
//                         dbo.MS_SD_BOOKING.CAR_PRICE, dbo.MS_SD_BOOKING.DISCOUNT, dbo.MS_SD_BOOKING.PRICE_AFTER_DISCOUNT, dbo.MS_SD_BOOKING.VAT, dbo.MS_SD_BOOKING.TOTAL, dbo.MS_SD_BOOKING.DEPOSIT
//ORDER BY dbo.MS_SD_BOOKING.BOOKING_DATE");

//            SqlConnection myconnet1;
//            SqlDataAdapter adapter1 = new SqlDataAdapter();
//            DataSet ds1 = new DataSet();
//            //connetionString = "Data Source=192.168.111.13;Initial Catalog=VgroupDB;User ID=sa;Password=siriwan";
//            myconnet1 = new SqlConnection(All_VG.sqlcw);

//            myconnet1.Open();
//            adapter1.SelectCommand = new SqlCommand(sqlquerycw, myconnet1);
//            //where CHK_Print = '0'
//            adapter1.Fill(ds1);
//            myconnet1.Close();

//            string sqlquerynk = String.Format(@"SELECT        dbo.MS_SD_BOOKING.DEALER_CODE, dbo.MS_SD_BOOKING.BOOKING_NO, dbo.MS_SD_BOOKING.BOOKING_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.MODEL_YEAR, 
//                         dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.BOOK_CUSTOMER_NO, dbo.MS_SD_BOOKING.BOOK_CUS_SIR_NAME, 
//                         dbo.MS_SD_BOOKING.BOOK_CUS_FIRST_NAME, dbo.MS_SD_BOOKING.BOOK_CUS_LAST_NAME, dbo.MS_SD_BOOKING.STAFF_CODE, dbo.MS_SD_BOOKING.STAFF_FIRST_NAME, 
//                         dbo.MS_SD_BOOKING.STAFF_LAST_NAME, ' -> ' AS Vehicle, dbo.MS_SD_BOOKING.FRAME_NO, dbo.MS_SD_BOOKING.ALLOCATION_DATE, dbo.MS_SD_BOOKING.SERIES_NAME AS Expr1, 
//                         dbo.MS_SD_BOOKING.SERIES_NAME + N' ' + dbo.MS_SD_BOOKING.MODEL_GRADE AS Models_Name, dbo.MS_SD_BOOKING.MODEL_CC, dbo.MS_SD_BOOKING.MODEL_GRADE AS Expr2, 
//                         dbo.MS_SD_BOOKING.MODEL_COLOR AS Expr3, dbo.MS_SD_BOOKING.MODEL_YEAR AS Expr4, dbo.MS_SD_BOOKING.MTOC, dbo.MS_SD_BOOKING.CAR_PRICE, dbo.MS_SD_BOOKING.DISCOUNT, 
//                         dbo.MS_SD_BOOKING.PRICE_AFTER_DISCOUNT, dbo.MS_SD_BOOKING.VAT, dbo.MS_SD_BOOKING.TOTAL, dbo.MS_SD_BOOKING.DEPOSIT
//FROM            dbo.MS_SD_BOOKING INNER JOIN
//                         dbo.MS_SD_BOOKING_TYPE ON dbo.MS_SD_BOOKING.BOOKING_STATUS = dbo.MS_SD_BOOKING_TYPE.BOOKING_STATUS
//WHERE        (YEAR(dbo.MS_SD_BOOKING.BOOKING_DATE) = '2019')
//GROUP BY dbo.MS_SD_BOOKING.DEALER_CODE, dbo.MS_SD_BOOKING.BOOKING_NO, dbo.MS_SD_BOOKING.BOOKING_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.MODEL_YEAR, 
//                         dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.BOOK_CUSTOMER_NO, dbo.MS_SD_BOOKING.BOOK_CUS_SIR_NAME, 
//                         dbo.MS_SD_BOOKING.BOOK_CUS_FIRST_NAME, dbo.MS_SD_BOOKING.BOOK_CUS_LAST_NAME, dbo.MS_SD_BOOKING.STAFF_CODE, dbo.MS_SD_BOOKING.STAFF_FIRST_NAME, 
//                         dbo.MS_SD_BOOKING.STAFF_LAST_NAME, dbo.MS_SD_BOOKING.FRAME_NO, dbo.MS_SD_BOOKING.ALLOCATION_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.SERIES_NAME, 
//                         dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_CC, dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.MODEL_YEAR, dbo.MS_SD_BOOKING.MTOC, 
//                         dbo.MS_SD_BOOKING.CAR_PRICE, dbo.MS_SD_BOOKING.DISCOUNT, dbo.MS_SD_BOOKING.PRICE_AFTER_DISCOUNT, dbo.MS_SD_BOOKING.VAT, dbo.MS_SD_BOOKING.TOTAL, dbo.MS_SD_BOOKING.DEPOSIT
//ORDER BY dbo.MS_SD_BOOKING.BOOKING_DATE");

//            SqlConnection myconnet12;
//            SqlDataAdapter adapter12 = new SqlDataAdapter();
//            DataSet ds12 = new DataSet();
//            //connetionString = "Data Source=192.168.111.13;Initial Catalog=VgroupDB;User ID=sa;Password=siriwan";
//            myconnet12 = new SqlConnection(All_VG.sqlnk);

//            myconnet12.Open();
//            adapter12.SelectCommand = new SqlCommand(sqlquerynk, myconnet12);
//            //where CHK_Print = '0'
//            adapter12.Fill(ds12);
//            myconnet12.Close();

//            string sqlquerybn = String.Format(@"SELECT        dbo.MS_SD_BOOKING.DEALER_CODE, dbo.MS_SD_BOOKING.BOOKING_NO, dbo.MS_SD_BOOKING.BOOKING_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.MODEL_YEAR, 
//                         dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.BOOK_CUSTOMER_NO, dbo.MS_SD_BOOKING.BOOK_CUS_SIR_NAME, 
//                         dbo.MS_SD_BOOKING.BOOK_CUS_FIRST_NAME, dbo.MS_SD_BOOKING.BOOK_CUS_LAST_NAME, dbo.MS_SD_BOOKING.STAFF_CODE, dbo.MS_SD_BOOKING.STAFF_FIRST_NAME, 
//                         dbo.MS_SD_BOOKING.STAFF_LAST_NAME, ' -> ' AS Vehicle, dbo.MS_SD_BOOKING.FRAME_NO, dbo.MS_SD_BOOKING.ALLOCATION_DATE, dbo.MS_SD_BOOKING.SERIES_NAME AS Expr1, 
//                         dbo.MS_SD_BOOKING.SERIES_NAME + N' ' + dbo.MS_SD_BOOKING.MODEL_GRADE AS Models_Name, dbo.MS_SD_BOOKING.MODEL_CC, dbo.MS_SD_BOOKING.MODEL_GRADE AS Expr2, 
//                         dbo.MS_SD_BOOKING.MODEL_COLOR AS Expr3, dbo.MS_SD_BOOKING.MODEL_YEAR AS Expr4, dbo.MS_SD_BOOKING.MTOC, dbo.MS_SD_BOOKING.CAR_PRICE, dbo.MS_SD_BOOKING.DISCOUNT, 
//                         dbo.MS_SD_BOOKING.PRICE_AFTER_DISCOUNT, dbo.MS_SD_BOOKING.VAT, dbo.MS_SD_BOOKING.TOTAL, dbo.MS_SD_BOOKING.DEPOSIT
//FROM            dbo.MS_SD_BOOKING INNER JOIN
//                         dbo.MS_SD_BOOKING_TYPE ON dbo.MS_SD_BOOKING.BOOKING_STATUS = dbo.MS_SD_BOOKING_TYPE.BOOKING_STATUS
//WHERE        (YEAR(dbo.MS_SD_BOOKING.BOOKING_DATE) = '2019')
//GROUP BY dbo.MS_SD_BOOKING.DEALER_CODE, dbo.MS_SD_BOOKING.BOOKING_NO, dbo.MS_SD_BOOKING.BOOKING_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.MODEL_YEAR, 
//                         dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.BOOK_CUSTOMER_NO, dbo.MS_SD_BOOKING.BOOK_CUS_SIR_NAME, 
//                         dbo.MS_SD_BOOKING.BOOK_CUS_FIRST_NAME, dbo.MS_SD_BOOKING.BOOK_CUS_LAST_NAME, dbo.MS_SD_BOOKING.STAFF_CODE, dbo.MS_SD_BOOKING.STAFF_FIRST_NAME, 
//                         dbo.MS_SD_BOOKING.STAFF_LAST_NAME, dbo.MS_SD_BOOKING.FRAME_NO, dbo.MS_SD_BOOKING.ALLOCATION_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.SERIES_NAME, 
//                         dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_CC, dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.MODEL_YEAR, dbo.MS_SD_BOOKING.MTOC, 
//                         dbo.MS_SD_BOOKING.CAR_PRICE, dbo.MS_SD_BOOKING.DISCOUNT, dbo.MS_SD_BOOKING.PRICE_AFTER_DISCOUNT, dbo.MS_SD_BOOKING.VAT, dbo.MS_SD_BOOKING.TOTAL, dbo.MS_SD_BOOKING.DEPOSIT
//ORDER BY dbo.MS_SD_BOOKING.BOOKING_DATE");

//            SqlConnection myconnet13;
//            SqlDataAdapter adapter13 = new SqlDataAdapter();
//            DataSet ds13 = new DataSet();
//            //connetionString = "Data Source=192.168.111.13;Initial Catalog=VgroupDB;User ID=sa;Password=siriwan";
//            myconnet13 = new SqlConnection(All_VG.sqlbn);

//            myconnet13.Open();
//            adapter13.SelectCommand = new SqlCommand(sqlquerybn, myconnet13);
//            //where CHK_Print = '0'
//            adapter13.Fill(ds13);
//            myconnet13.Close();

//            string sqlquerypm = String.Format(@"SELECT        dbo.MS_SD_BOOKING.DEALER_CODE, dbo.MS_SD_BOOKING.BOOKING_NO, dbo.MS_SD_BOOKING.BOOKING_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.MODEL_YEAR, 
//                         dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.BOOK_CUSTOMER_NO, dbo.MS_SD_BOOKING.BOOK_CUS_SIR_NAME, 
//                         dbo.MS_SD_BOOKING.BOOK_CUS_FIRST_NAME, dbo.MS_SD_BOOKING.BOOK_CUS_LAST_NAME, dbo.MS_SD_BOOKING.STAFF_CODE, dbo.MS_SD_BOOKING.STAFF_FIRST_NAME, 
//                         dbo.MS_SD_BOOKING.STAFF_LAST_NAME, ' -> ' AS Vehicle, dbo.MS_SD_BOOKING.FRAME_NO, dbo.MS_SD_BOOKING.ALLOCATION_DATE, dbo.MS_SD_BOOKING.SERIES_NAME AS Expr1, 
//                         dbo.MS_SD_BOOKING.SERIES_NAME + N' ' + dbo.MS_SD_BOOKING.MODEL_GRADE AS Models_Name, dbo.MS_SD_BOOKING.MODEL_CC, dbo.MS_SD_BOOKING.MODEL_GRADE AS Expr2, 
//                         dbo.MS_SD_BOOKING.MODEL_COLOR AS Expr3, dbo.MS_SD_BOOKING.MODEL_YEAR AS Expr4, dbo.MS_SD_BOOKING.MTOC, dbo.MS_SD_BOOKING.CAR_PRICE, dbo.MS_SD_BOOKING.DISCOUNT, 
//                         dbo.MS_SD_BOOKING.PRICE_AFTER_DISCOUNT, dbo.MS_SD_BOOKING.VAT, dbo.MS_SD_BOOKING.TOTAL, dbo.MS_SD_BOOKING.DEPOSIT
//FROM            dbo.MS_SD_BOOKING INNER JOIN
//                         dbo.MS_SD_BOOKING_TYPE ON dbo.MS_SD_BOOKING.BOOKING_STATUS = dbo.MS_SD_BOOKING_TYPE.BOOKING_STATUS
//WHERE        (YEAR(dbo.MS_SD_BOOKING.BOOKING_DATE) = '2019')
//GROUP BY dbo.MS_SD_BOOKING.DEALER_CODE, dbo.MS_SD_BOOKING.BOOKING_NO, dbo.MS_SD_BOOKING.BOOKING_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.MODEL_YEAR, 
//                         dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.BOOK_CUSTOMER_NO, dbo.MS_SD_BOOKING.BOOK_CUS_SIR_NAME, 
//                         dbo.MS_SD_BOOKING.BOOK_CUS_FIRST_NAME, dbo.MS_SD_BOOKING.BOOK_CUS_LAST_NAME, dbo.MS_SD_BOOKING.STAFF_CODE, dbo.MS_SD_BOOKING.STAFF_FIRST_NAME, 
//                         dbo.MS_SD_BOOKING.STAFF_LAST_NAME, dbo.MS_SD_BOOKING.FRAME_NO, dbo.MS_SD_BOOKING.ALLOCATION_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.SERIES_NAME, 
//                         dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_CC, dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.MODEL_YEAR, dbo.MS_SD_BOOKING.MTOC, 
//                         dbo.MS_SD_BOOKING.CAR_PRICE, dbo.MS_SD_BOOKING.DISCOUNT, dbo.MS_SD_BOOKING.PRICE_AFTER_DISCOUNT, dbo.MS_SD_BOOKING.VAT, dbo.MS_SD_BOOKING.TOTAL, dbo.MS_SD_BOOKING.DEPOSIT
//ORDER BY dbo.MS_SD_BOOKING.BOOKING_DATE");

//            SqlConnection myconnet14;
//            SqlDataAdapter adapter14 = new SqlDataAdapter();
//            DataSet ds14 = new DataSet();
//            //connetionString = "Data Source=192.168.111.13;Initial Catalog=VgroupDB;User ID=sa;Password=siriwan";
//            myconnet14 = new SqlConnection(All_VG.sqlpm);

//            myconnet14.Open();
//            adapter14.SelectCommand = new SqlCommand(sqlquerypm, myconnet14);
//            //where CHK_Print = '0'
//            adapter14.Fill(ds14);
//            myconnet14.Close();

//            ds1.Merge(ds12);
//            ds1.Merge(ds13);
//            ds1.Merge(ds14);
//            DataSet ds15 = ds1;

//            //GVshow0.KeyFieldName = "SEQ";
//            Session["dtHD_Create_MartandSupplier1"] = ds15;
//            GVshow0.DataSource = Session["dtHD_Create_MartandSupplier1"];
//            GVshow0.DataBind();
        }
        protected void Render_Chart()
        {
            // define the connection string
            string constringpm = "Data Source=192.168.112.10;Initial Catalog=AI_10143;User ID=sa;Password=10143";
            string constringcw = "Data Source=192.168.111.10;Initial Catalog=AI_10112;User ID=sa;Password=10112";
            string constringnk = "Data Source=192.168.114.10;Initial Catalog=AI_10115;User ID=sa;Password=10115";
            string constringbn = "Data Source=192.168.115.10;Initial Catalog=AI_10126;User ID=sa;Password=10126";

            // Declare the SQL connection

            SqlConnection myConnpm = new SqlConnection(constringpm);
            // and add a query string for retrieving the data.
            //string commandText = "select period, count(pizza) from pizzaDB group by period order by period";
            string commandTextpm = "SELECT MONTH(BOOKING_DATE) ,COUNT([BOOKING_NO]) FROM [Vgh-ids-Booking] where YEAR(BOOKING_DATE) = '"+CByear.Text+"' group by  MONTH(BOOKING_DATE) order by  MONTH(BOOKING_DATE) asc";
            SqlCommand myCommpm = new SqlCommand(commandTextpm, myConnpm);
            // Open the connection
            myConnpm.Open();

            // and execute the query
            SqlDataReader readerpm = myCommpm.ExecuteReader();

            Object[] chartValuespm = new Object[12]; // declare an object for the chart rendering  
            if (readerpm.HasRows)
            {
                while (readerpm.Read())
                {
                    // GetValue() returns the data row from the query
                    // So:
                    //       GetValue(0) will contain the month number [<em>month(eaten_Pizza) as Mese</em>]
                    //       GetValue(1) will contain the number of eaten pizzas [<em>count(eaten_Pizza)</em>]

                    chartValuespm[(Int32)readerpm.GetValue(0) - 1] = readerpm.GetValue(1);
                    // minus 1 because the array starts from 0, whenever the months start from 1
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            readerpm.Close(); // close the reader

            // Declare the SQL connection

            SqlConnection myConncw = new SqlConnection(constringcw);
            // and add a query string for retrieving the data.
            //string commandText = "select period, count(pizza) from pizzaDB group by period order by period";
            string commandTextcw = "SELECT MONTH(BOOKING_DATE) ,COUNT([BOOKING_NO]) FROM [Vgh-ids-Booking] where YEAR(BOOKING_DATE) = '" + CByear.Text + "' group by  MONTH(BOOKING_DATE) order by  MONTH(BOOKING_DATE) asc";
            SqlCommand myCommcw = new SqlCommand(commandTextcw, myConncw);
            // Open the connection
            myConncw.Open();

            // and execute the query
            SqlDataReader readercw = myCommcw.ExecuteReader();

            Object[] chartValuescw = new Object[12]; // declare an object for the chart rendering  
            if (readercw.HasRows)
            {
                while (readercw.Read())
                {
                    // GetValue() returns the data row from the query
                    // So:
                    //       GetValue(0) will contain the month number [<em>month(eaten_Pizza) as Mese</em>]
                    //       GetValue(1) will contain the number of eaten pizzas [<em>count(eaten_Pizza)</em>]

                    chartValuescw[(Int32)readercw.GetValue(0) - 1] = readercw.GetValue(1);
                    // minus 1 because the array starts from 0, whenever the months start from 1
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            readercw.Close(); // close the reader

            // Declare the SQL connection

            SqlConnection myConnnk = new SqlConnection(constringnk);
            // and add a query string for retrieving the data.
            //string commandText = "select period, count(pizza) from pizzaDB group by period order by period";
            string commandTextnk = "SELECT MONTH(BOOKING_DATE) ,COUNT([BOOKING_NO]) FROM [Vgh-ids-Booking] where YEAR(BOOKING_DATE) = '" + CByear.Text + "' group by  MONTH(BOOKING_DATE) order by  MONTH(BOOKING_DATE) asc";
            SqlCommand myCommnk = new SqlCommand(commandTextnk, myConnnk);
            // Open the connection
            myConnnk.Open();

            // and execute the query
            SqlDataReader readernk = myCommnk.ExecuteReader();

            Object[] chartValuesnk = new Object[12]; // declare an object for the chart rendering  
            if (readernk.HasRows)
            {
                while (readernk.Read())
                {
                    // GetValue() returns the data row from the query
                    // So:
                    //       GetValue(0) will contain the month number [<em>month(eaten_Pizza) as Mese</em>]
                    //       GetValue(1) will contain the number of eaten pizzas [<em>count(eaten_Pizza)</em>]

                    chartValuesnk[(Int32)readernk.GetValue(0) - 1] = readernk.GetValue(1);
                    // minus 1 because the array starts from 0, whenever the months start from 1
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            readernk.Close(); // close the reader

            // Declare the SQL connection

            SqlConnection myConnbn = new SqlConnection(constringbn);
            // and add a query string for retrieving the data.
            //string commandText = "select period, count(pizza) from pizzaDB group by period order by period";
            string commandTextbn = "SELECT MONTH(BOOKING_DATE) ,COUNT([BOOKING_NO]) FROM [Vgh-ids-Booking] where YEAR(BOOKING_DATE) = '" + CByear.Text + "' group by  MONTH(BOOKING_DATE) order by  MONTH(BOOKING_DATE) asc";
            SqlCommand myCommbn = new SqlCommand(commandTextbn, myConnbn);
            // Open the connection
            myConnbn.Open();

            // and execute the query
            SqlDataReader readerbn = myCommbn.ExecuteReader();

            Object[] chartValuesbn = new Object[12]; // declare an object for the chart rendering  
            if (readerbn.HasRows)
            {
                while (readerbn.Read())
                {
                    // GetValue() returns the data row from the query
                    // So:
                    //       GetValue(0) will contain the month number [<em>month(eaten_Pizza) as Mese</em>]
                    //       GetValue(1) will contain the number of eaten pizzas [<em>count(eaten_Pizza)</em>]

                    chartValuesbn[(Int32)readerbn.GetValue(0) - 1] = readerbn.GetValue(1);
                    // minus 1 because the array starts from 0, whenever the months start from 1
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            readerbn.Close(); // close the reader


            // Declare the HighCharts object    
            if (TypeGraph.Value == "colunm")
            {
                DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts("chart").InitChart(new Chart { DefaultSeriesType = ChartTypes.Column })
                .SetTooltip(new Tooltip
                {
                    //HeaderFormat = "",
                    //PointFormat = "",
                    //FooterFormat = "",
                    //        <tr><td style="color:{series.color};padding:0">{series.name}: </ td > ' +
                    //'<td style="padding:0"><b>{point.y:.1f} mm</b></td></tr>'
                    Enabled = true,
                    UseHTML = true,
                    Shared = true
                })

                .SetPlotOptions(new PlotOptions
                {
                    Column = new PlotOptionsColumn
                    {
                        PointPadding = 0.2,
                        BorderWidth = 0
                    }
                })
                .SetTitle(new Title
                {
                    Text = "Booking in Monthly",
                    X = -20
                })

                .SetSubtitle(new Subtitle
                {
                    Text = "Source: Booking DB",
                    X = -20
                })
                .SetXAxis(new XAxis
                {
                    Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                })
                .SetYAxis(new YAxis
                {
                    Title = new YAxisTitle { Text = "จำนวน Booking", Style = "background: '#ffffff'" }
                })
                .SetSeries(new[]
                        {
                new Series
                {
                    Name = "ปากเกร็ด-เมืองทอง",
                    Data = new Data(chartValuespm)   // Here we put the dbase data into the chart                   
                },
                new Series
                {
                    Name = "แจ้งวัฒนะ",
                    Data = new Data(chartValuescw)   // Here we put the dbase data into the chart                   
                },
                new Series
                {
                    Name = "หนองแขม",
                    Data = new Data(chartValuesnk)   // Here we put the dbase data into the chart                   
                },
                new Series
                {
                    Name = "บางกอกน้อย",
                    Data = new Data(chartValuesbn)   // Here we put the dbase data into the chart                   
                }
                    });


                container.InnerHtml = chart.ToHtmlString(); // Let's visualize the chart into the webform.
            }
            // Declare the HighCharts object    
            if (TypeGraph.Value == "Line")
            {
                DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts("chart").InitChart(new Chart { DefaultSeriesType = ChartTypes.Line })
                .SetTooltip(new Tooltip
                {
                    //HeaderFormat = "",
                    //PointFormat = "",
                    //FooterFormat = "",
                    //        <tr><td style="color:{series.color};padding:0">{series.name}: </ td > ' +
                    //'<td style="padding:0"><b>{point.y:.1f} mm</b></td></tr>'
                    Enabled = true,
                    UseHTML = true,
                    Shared = true
                })

                .SetPlotOptions(new PlotOptions
                {
                    Column = new PlotOptionsColumn
                    {
                        PointPadding = 0.2,
                        BorderWidth = 0
                    }
                })
                .SetTitle(new Title
                {
                    Text = "Booking in Monthly",
                    X = -20
                })

                .SetSubtitle(new Subtitle
                {
                    Text = "Source: Booking DB",
                    X = -20
                })
                .SetXAxis(new XAxis
                {
                    Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                })
                .SetYAxis(new YAxis
                {
                    Title = new YAxisTitle { Text = "จำนวน Booking", Style = "background: '#ffffff'" }
                })
                .SetSeries(new[]
                        {
                new Series
                {
                    Name = "ปากเกร็ด-เมืองทอง",
                    Data = new Data(chartValuespm)   // Here we put the dbase data into the chart                   
                },
                new Series
                {
                    Name = "แจ้งวัฒนะ",
                    Data = new Data(chartValuescw)   // Here we put the dbase data into the chart                   
                },
                new Series
                {
                    Name = "หนองแขม",
                    Data = new Data(chartValuesnk)   // Here we put the dbase data into the chart                   
                },
                new Series
                {
                    Name = "บางกอกน้อย",
                    Data = new Data(chartValuesbn)   // Here we put the dbase data into the chart                   
                }
                    });


                container.InnerHtml = chart.ToHtmlString(); // Let's visualize the chart into the webform.
            }
            if (TypeGraph.Value == "Area")
            {
                DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts("chart").InitChart(new Chart { DefaultSeriesType = ChartTypes.Area })
                .SetTooltip(new Tooltip
                {
                    //HeaderFormat = "",
                    //PointFormat = "",
                    //FooterFormat = "",
                    //        <tr><td style="color:{series.color};padding:0">{series.name}: </ td > ' +
                    //'<td style="padding:0"><b>{point.y:.1f} mm</b></td></tr>'
                    Enabled = true,
                    UseHTML = true,
                    Shared = true
                })

                .SetPlotOptions(new PlotOptions
                {
                    Column = new PlotOptionsColumn
                    {
                        PointPadding = 0.2,
                        BorderWidth = 0
                    }
                })
                .SetTitle(new Title
                {
                    Text = "Booking in Monthly",
                    X = -20
                })

                .SetSubtitle(new Subtitle
                {
                    Text = "Source: Booking DB",
                    X = -20
                })
                .SetXAxis(new XAxis
                {
                    Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                })
                .SetYAxis(new YAxis
                {
                    Title = new YAxisTitle { Text = "จำนวน Booking", Style = "background: '#ffffff'" }
                })
                .SetSeries(new[]
                        {
                new Series
                {
                    Name = "ปากเกร็ด-เมืองทอง",
                    Data = new Data(chartValuespm)   // Here we put the dbase data into the chart                   
                },
                new Series
                {
                    Name = "แจ้งวัฒนะ",
                    Data = new Data(chartValuescw)   // Here we put the dbase data into the chart                   
                },
                new Series
                {
                    Name = "หนองแขม",
                    Data = new Data(chartValuesnk)   // Here we put the dbase data into the chart                   
                },
                new Series
                {
                    Name = "บางกอกน้อย",
                    Data = new Data(chartValuesbn)   // Here we put the dbase data into the chart                   
                }
                    });


                container.InnerHtml = chart.ToHtmlString(); // Let's visualize the chart into the webform.
            }           

            GVshow0.Visible = false;

        }

        protected void CBoutlet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LBtypeselect.Text == "Booking New Cars")
            {
                if(CBoutlet.Value == "ทั้งหมด")
                {
                    GVshow0.Visible = false;
                    Render_Chart();
                }
                if(CBoutlet.Value == "0112")
                {
                    GVshow0.Visible = true;
                    Render_Chartcw();
                    string sqlquerycw = String.Format(@"SELECT        dbo.MS_SD_BOOKING.DEALER_CODE, dbo.MS_SD_BOOKING.BOOKING_NO, dbo.MS_SD_BOOKING.BOOKING_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.MODEL_YEAR, 
                         dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.BOOK_CUSTOMER_NO, dbo.MS_SD_BOOKING.BOOK_CUS_SIR_NAME, 
                         dbo.MS_SD_BOOKING.BOOK_CUS_FIRST_NAME, dbo.MS_SD_BOOKING.BOOK_CUS_LAST_NAME, dbo.MS_SD_BOOKING.STAFF_CODE, dbo.MS_SD_BOOKING.STAFF_FIRST_NAME, 
                         dbo.MS_SD_BOOKING.STAFF_LAST_NAME, ' -> ' AS Vehicle, dbo.MS_SD_BOOKING.FRAME_NO, dbo.MS_SD_BOOKING.ALLOCATION_DATE, dbo.MS_SD_BOOKING.SERIES_NAME AS Expr1, 
                         dbo.MS_SD_BOOKING.SERIES_NAME + N' ' + dbo.MS_SD_BOOKING.MODEL_GRADE AS Models_Name, dbo.MS_SD_BOOKING.MODEL_CC, dbo.MS_SD_BOOKING.MODEL_GRADE AS Expr2, 
                         dbo.MS_SD_BOOKING.MODEL_COLOR AS Expr3, dbo.MS_SD_BOOKING.MODEL_YEAR AS Expr4, dbo.MS_SD_BOOKING.MTOC, dbo.MS_SD_BOOKING.CAR_PRICE, dbo.MS_SD_BOOKING.DISCOUNT, 
                         dbo.MS_SD_BOOKING.PRICE_AFTER_DISCOUNT, dbo.MS_SD_BOOKING.VAT, dbo.MS_SD_BOOKING.TOTAL, dbo.MS_SD_BOOKING.DEPOSIT
FROM            dbo.MS_SD_BOOKING INNER JOIN
                         dbo.MS_SD_BOOKING_TYPE ON dbo.MS_SD_BOOKING.BOOKING_STATUS = dbo.MS_SD_BOOKING_TYPE.BOOKING_STATUS
WHERE        (YEAR(dbo.MS_SD_BOOKING.BOOKING_DATE) = '"+ CByear.Text+"') GROUP BY dbo.MS_SD_BOOKING.DEALER_CODE, dbo.MS_SD_BOOKING.BOOKING_NO, dbo.MS_SD_BOOKING.BOOKING_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.MODEL_YEAR, dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.BOOK_CUSTOMER_NO, dbo.MS_SD_BOOKING.BOOK_CUS_SIR_NAME, dbo.MS_SD_BOOKING.BOOK_CUS_FIRST_NAME, dbo.MS_SD_BOOKING.BOOK_CUS_LAST_NAME, dbo.MS_SD_BOOKING.STAFF_CODE, dbo.MS_SD_BOOKING.STAFF_FIRST_NAME, dbo.MS_SD_BOOKING.STAFF_LAST_NAME, dbo.MS_SD_BOOKING.FRAME_NO, dbo.MS_SD_BOOKING.ALLOCATION_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_CC, dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.MODEL_YEAR, dbo.MS_SD_BOOKING.MTOC, dbo.MS_SD_BOOKING.CAR_PRICE, dbo.MS_SD_BOOKING.DISCOUNT, dbo.MS_SD_BOOKING.PRICE_AFTER_DISCOUNT, dbo.MS_SD_BOOKING.VAT, dbo.MS_SD_BOOKING.TOTAL, dbo.MS_SD_BOOKING.DEPOSIT ORDER BY dbo.MS_SD_BOOKING.BOOKING_DATE");

                    SqlConnection myconnet1;
                    SqlDataAdapter adapter1 = new SqlDataAdapter();
                    DataSet ds1 = new DataSet();
                    //connetionString = "Data Source=192.168.111.13;Initial Catalog=VgroupDB;User ID=sa;Password=siriwan";
                    myconnet1 = new SqlConnection(All_VG.sqlcw);

                    myconnet1.Open();
                    adapter1.SelectCommand = new SqlCommand(sqlquerycw, myconnet1);
                    //where CHK_Print = '0'
                    adapter1.Fill(ds1);
                    myconnet1.Close();
                    Session["dtHD_Create_MartandSupplier1"] = ds1;
                    GVshow0.DataSource = Session["dtHD_Create_MartandSupplier1"];
                    GVshow0.DataBind();
                }
                if (CBoutlet.Value == "0113")
                {
                    GVshow0.Visible = true;
                    Render_Chartnk();
                    string sqlquerynk = String.Format(@"SELECT        dbo.MS_SD_BOOKING.DEALER_CODE, dbo.MS_SD_BOOKING.BOOKING_NO, dbo.MS_SD_BOOKING.BOOKING_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.MODEL_YEAR, 
                         dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.BOOK_CUSTOMER_NO, dbo.MS_SD_BOOKING.BOOK_CUS_SIR_NAME, 
                         dbo.MS_SD_BOOKING.BOOK_CUS_FIRST_NAME, dbo.MS_SD_BOOKING.BOOK_CUS_LAST_NAME, dbo.MS_SD_BOOKING.STAFF_CODE, dbo.MS_SD_BOOKING.STAFF_FIRST_NAME, 
                         dbo.MS_SD_BOOKING.STAFF_LAST_NAME, ' -> ' AS Vehicle, dbo.MS_SD_BOOKING.FRAME_NO, dbo.MS_SD_BOOKING.ALLOCATION_DATE, dbo.MS_SD_BOOKING.SERIES_NAME AS Expr1, 
                         dbo.MS_SD_BOOKING.SERIES_NAME + N' ' + dbo.MS_SD_BOOKING.MODEL_GRADE AS Models_Name, dbo.MS_SD_BOOKING.MODEL_CC, dbo.MS_SD_BOOKING.MODEL_GRADE AS Expr2, 
                         dbo.MS_SD_BOOKING.MODEL_COLOR AS Expr3, dbo.MS_SD_BOOKING.MODEL_YEAR AS Expr4, dbo.MS_SD_BOOKING.MTOC, dbo.MS_SD_BOOKING.CAR_PRICE, dbo.MS_SD_BOOKING.DISCOUNT, 
                         dbo.MS_SD_BOOKING.PRICE_AFTER_DISCOUNT, dbo.MS_SD_BOOKING.VAT, dbo.MS_SD_BOOKING.TOTAL, dbo.MS_SD_BOOKING.DEPOSIT
FROM            dbo.MS_SD_BOOKING INNER JOIN
                         dbo.MS_SD_BOOKING_TYPE ON dbo.MS_SD_BOOKING.BOOKING_STATUS = dbo.MS_SD_BOOKING_TYPE.BOOKING_STATUS
WHERE        (YEAR(dbo.MS_SD_BOOKING.BOOKING_DATE) = '" + CByear.Text + "') GROUP BY dbo.MS_SD_BOOKING.DEALER_CODE, dbo.MS_SD_BOOKING.BOOKING_NO, dbo.MS_SD_BOOKING.BOOKING_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.MODEL_YEAR, dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.BOOK_CUSTOMER_NO, dbo.MS_SD_BOOKING.BOOK_CUS_SIR_NAME, dbo.MS_SD_BOOKING.BOOK_CUS_FIRST_NAME, dbo.MS_SD_BOOKING.BOOK_CUS_LAST_NAME, dbo.MS_SD_BOOKING.STAFF_CODE, dbo.MS_SD_BOOKING.STAFF_FIRST_NAME, dbo.MS_SD_BOOKING.STAFF_LAST_NAME, dbo.MS_SD_BOOKING.FRAME_NO, dbo.MS_SD_BOOKING.ALLOCATION_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_CC, dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.MODEL_YEAR, dbo.MS_SD_BOOKING.MTOC, dbo.MS_SD_BOOKING.CAR_PRICE, dbo.MS_SD_BOOKING.DISCOUNT, dbo.MS_SD_BOOKING.PRICE_AFTER_DISCOUNT, dbo.MS_SD_BOOKING.VAT, dbo.MS_SD_BOOKING.TOTAL, dbo.MS_SD_BOOKING.DEPOSIT ORDER BY dbo.MS_SD_BOOKING.BOOKING_DATE");


                    SqlConnection myconnet1;
                    SqlDataAdapter adapter1 = new SqlDataAdapter();
                    DataSet ds1 = new DataSet();
                    //connetionString = "Data Source=192.168.111.13;Initial Catalog=VgroupDB;User ID=sa;Password=siriwan";
                    myconnet1 = new SqlConnection(All_VG.sqlnk);

                    myconnet1.Open();
                    adapter1.SelectCommand = new SqlCommand(sqlquerynk, myconnet1);
                    //where CHK_Print = '0'
                    adapter1.Fill(ds1);
                    myconnet1.Close();
                    Session["dtHD_Create_MartandSupplier1"] = ds1;
                    GVshow0.DataSource = Session["dtHD_Create_MartandSupplier1"];
                    GVshow0.DataBind();
                }
                if (CBoutlet.Value == "0115")
                {
                    GVshow0.Visible = true;
                    Render_Chartbn();
                    string sqlquerybn = String.Format(@"SELECT        dbo.MS_SD_BOOKING.DEALER_CODE, dbo.MS_SD_BOOKING.BOOKING_NO, dbo.MS_SD_BOOKING.BOOKING_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.MODEL_YEAR, 
                         dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.BOOK_CUSTOMER_NO, dbo.MS_SD_BOOKING.BOOK_CUS_SIR_NAME, 
                         dbo.MS_SD_BOOKING.BOOK_CUS_FIRST_NAME, dbo.MS_SD_BOOKING.BOOK_CUS_LAST_NAME, dbo.MS_SD_BOOKING.STAFF_CODE, dbo.MS_SD_BOOKING.STAFF_FIRST_NAME, 
                         dbo.MS_SD_BOOKING.STAFF_LAST_NAME, ' -> ' AS Vehicle, dbo.MS_SD_BOOKING.FRAME_NO, dbo.MS_SD_BOOKING.ALLOCATION_DATE, dbo.MS_SD_BOOKING.SERIES_NAME AS Expr1, 
                         dbo.MS_SD_BOOKING.SERIES_NAME + N' ' + dbo.MS_SD_BOOKING.MODEL_GRADE AS Models_Name, dbo.MS_SD_BOOKING.MODEL_CC, dbo.MS_SD_BOOKING.MODEL_GRADE AS Expr2, 
                         dbo.MS_SD_BOOKING.MODEL_COLOR AS Expr3, dbo.MS_SD_BOOKING.MODEL_YEAR AS Expr4, dbo.MS_SD_BOOKING.MTOC, dbo.MS_SD_BOOKING.CAR_PRICE, dbo.MS_SD_BOOKING.DISCOUNT, 
                         dbo.MS_SD_BOOKING.PRICE_AFTER_DISCOUNT, dbo.MS_SD_BOOKING.VAT, dbo.MS_SD_BOOKING.TOTAL, dbo.MS_SD_BOOKING.DEPOSIT
FROM            dbo.MS_SD_BOOKING INNER JOIN
                         dbo.MS_SD_BOOKING_TYPE ON dbo.MS_SD_BOOKING.BOOKING_STATUS = dbo.MS_SD_BOOKING_TYPE.BOOKING_STATUS
WHERE        (YEAR(dbo.MS_SD_BOOKING.BOOKING_DATE) = '" + CByear.Text + "') GROUP BY dbo.MS_SD_BOOKING.DEALER_CODE, dbo.MS_SD_BOOKING.BOOKING_NO, dbo.MS_SD_BOOKING.BOOKING_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.MODEL_YEAR, dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.BOOK_CUSTOMER_NO, dbo.MS_SD_BOOKING.BOOK_CUS_SIR_NAME, dbo.MS_SD_BOOKING.BOOK_CUS_FIRST_NAME, dbo.MS_SD_BOOKING.BOOK_CUS_LAST_NAME, dbo.MS_SD_BOOKING.STAFF_CODE, dbo.MS_SD_BOOKING.STAFF_FIRST_NAME, dbo.MS_SD_BOOKING.STAFF_LAST_NAME, dbo.MS_SD_BOOKING.FRAME_NO, dbo.MS_SD_BOOKING.ALLOCATION_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_CC, dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.MODEL_YEAR, dbo.MS_SD_BOOKING.MTOC, dbo.MS_SD_BOOKING.CAR_PRICE, dbo.MS_SD_BOOKING.DISCOUNT, dbo.MS_SD_BOOKING.PRICE_AFTER_DISCOUNT, dbo.MS_SD_BOOKING.VAT, dbo.MS_SD_BOOKING.TOTAL, dbo.MS_SD_BOOKING.DEPOSIT ORDER BY dbo.MS_SD_BOOKING.BOOKING_DATE");


                    SqlConnection myconnet1;
                    SqlDataAdapter adapter1 = new SqlDataAdapter();
                    DataSet ds1 = new DataSet();
                    //connetionString = "Data Source=192.168.111.13;Initial Catalog=VgroupDB;User ID=sa;Password=siriwan";
                    myconnet1 = new SqlConnection(All_VG.sqlbn);

                    myconnet1.Open();
                    adapter1.SelectCommand = new SqlCommand(sqlquerybn, myconnet1);
                    //where CHK_Print = '0'
                    adapter1.Fill(ds1);
                    myconnet1.Close();
                    Session["dtHD_Create_MartandSupplier1"] = ds1;
                    GVshow0.DataSource = Session["dtHD_Create_MartandSupplier1"];
                    GVshow0.DataBind();
                }
                if (CBoutlet.Value == "0116")
                {
                    GVshow0.Visible = true;
                    Render_Chartpm();
                    string sqlquerypm = String.Format(@"SELECT        dbo.MS_SD_BOOKING.DEALER_CODE, dbo.MS_SD_BOOKING.BOOKING_NO, dbo.MS_SD_BOOKING.BOOKING_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.MODEL_YEAR, 
                         dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.BOOK_CUSTOMER_NO, dbo.MS_SD_BOOKING.BOOK_CUS_SIR_NAME, 
                         dbo.MS_SD_BOOKING.BOOK_CUS_FIRST_NAME, dbo.MS_SD_BOOKING.BOOK_CUS_LAST_NAME, dbo.MS_SD_BOOKING.STAFF_CODE, dbo.MS_SD_BOOKING.STAFF_FIRST_NAME, 
                         dbo.MS_SD_BOOKING.STAFF_LAST_NAME, ' -> ' AS Vehicle, dbo.MS_SD_BOOKING.FRAME_NO, dbo.MS_SD_BOOKING.ALLOCATION_DATE, dbo.MS_SD_BOOKING.SERIES_NAME AS Expr1, 
                         dbo.MS_SD_BOOKING.SERIES_NAME + N' ' + dbo.MS_SD_BOOKING.MODEL_GRADE AS Models_Name, dbo.MS_SD_BOOKING.MODEL_CC, dbo.MS_SD_BOOKING.MODEL_GRADE AS Expr2, 
                         dbo.MS_SD_BOOKING.MODEL_COLOR AS Expr3, dbo.MS_SD_BOOKING.MODEL_YEAR AS Expr4, dbo.MS_SD_BOOKING.MTOC, dbo.MS_SD_BOOKING.CAR_PRICE, dbo.MS_SD_BOOKING.DISCOUNT, 
                         dbo.MS_SD_BOOKING.PRICE_AFTER_DISCOUNT, dbo.MS_SD_BOOKING.VAT, dbo.MS_SD_BOOKING.TOTAL, dbo.MS_SD_BOOKING.DEPOSIT
FROM            dbo.MS_SD_BOOKING INNER JOIN
                         dbo.MS_SD_BOOKING_TYPE ON dbo.MS_SD_BOOKING.BOOKING_STATUS = dbo.MS_SD_BOOKING_TYPE.BOOKING_STATUS
WHERE        (YEAR(dbo.MS_SD_BOOKING.BOOKING_DATE) = '" + CByear.Text + "') GROUP BY dbo.MS_SD_BOOKING.DEALER_CODE, dbo.MS_SD_BOOKING.BOOKING_NO, dbo.MS_SD_BOOKING.BOOKING_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.MODEL_YEAR, dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.BOOK_CUSTOMER_NO, dbo.MS_SD_BOOKING.BOOK_CUS_SIR_NAME, dbo.MS_SD_BOOKING.BOOK_CUS_FIRST_NAME, dbo.MS_SD_BOOKING.BOOK_CUS_LAST_NAME, dbo.MS_SD_BOOKING.STAFF_CODE, dbo.MS_SD_BOOKING.STAFF_FIRST_NAME, dbo.MS_SD_BOOKING.STAFF_LAST_NAME, dbo.MS_SD_BOOKING.FRAME_NO, dbo.MS_SD_BOOKING.ALLOCATION_DATE, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.SERIES_NAME, dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_CC, dbo.MS_SD_BOOKING.MODEL_GRADE, dbo.MS_SD_BOOKING.MODEL_COLOR, dbo.MS_SD_BOOKING.MODEL_YEAR, dbo.MS_SD_BOOKING.MTOC, dbo.MS_SD_BOOKING.CAR_PRICE, dbo.MS_SD_BOOKING.DISCOUNT, dbo.MS_SD_BOOKING.PRICE_AFTER_DISCOUNT, dbo.MS_SD_BOOKING.VAT, dbo.MS_SD_BOOKING.TOTAL, dbo.MS_SD_BOOKING.DEPOSIT ORDER BY dbo.MS_SD_BOOKING.BOOKING_DATE");


                    SqlConnection myconnet1;
                    SqlDataAdapter adapter1 = new SqlDataAdapter();
                    DataSet ds1 = new DataSet();
                    //connetionString = "Data Source=192.168.111.13;Initial Catalog=VgroupDB;User ID=sa;Password=siriwan";
                    myconnet1 = new SqlConnection(All_VG.sqlpm);

                    myconnet1.Open();
                    adapter1.SelectCommand = new SqlCommand(sqlquerypm, myconnet1);
                    //where CHK_Print = '0'
                    adapter1.Fill(ds1);
                    myconnet1.Close();
                    Session["dtHD_Create_MartandSupplier1"] = ds1;
                    GVshow0.DataSource = Session["dtHD_Create_MartandSupplier1"];
                    GVshow0.DataBind();
                }
            }
        }
        protected void Render_Chartcw()
        {          
            // Declare the SQL connection

            SqlConnection myConn = new SqlConnection(All_VG.sqlcw);
            // and add a query string for retrieving the data.
            //string commandText = "select period, count(pizza) from pizzaDB group by period order by period";
            string commandText = "SELECT MONTH(BOOKING_DATE) ,COUNT([BOOKING_NO]) FROM [Vgh-ids-Booking] where YEAR(BOOKING_DATE) = '"+CByear.Text+"' group by  MONTH(BOOKING_DATE) order by  MONTH(BOOKING_DATE) asc";
            SqlCommand myComm = new SqlCommand(commandText, myConn);
            // Open the connection
            myConn.Open();

            // and execute the query
            SqlDataReader reader = myComm.ExecuteReader();

            Object[] chartValues = new Object[12]; // declare an object for the chart rendering  
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    // GetValue() returns the data row from the query
                    // So:
                    //       GetValue(0) will contain the month number [<em>month(eaten_Pizza) as Mese</em>]
                    //       GetValue(1) will contain the number of eaten pizzas [<em>count(eaten_Pizza)</em>]

                    chartValues[(Int32)reader.GetValue(0) - 1] = reader.GetValue(1);
                    // minus 1 because the array starts from 0, whenever the months start from 1
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close(); // close the reader          

            // Declare the HighCharts object 
            if (TypeGraph.Value == "colunm")
            {
                DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts("chart").InitChart(new Chart { DefaultSeriesType = ChartTypes.Column })
                .SetTooltip(new Tooltip
                {
                    //HeaderFormat = "",
                    //PointFormat = "",
                    //FooterFormat = "",
                    //        <tr><td style="color:{series.color};padding:0">{series.name}: </ td > ' +
                    //'<td style="padding:0"><b>{point.y:.1f} mm</b></td></tr>'
                    Enabled = true,
                    UseHTML = true,
                    Shared = true
                })

                .SetPlotOptions(new PlotOptions
                {
                    Column = new PlotOptionsColumn
                    {
                        PointPadding = 0.2,
                        BorderWidth = 0
                    }
                })
                .SetTitle(new Title
                {
                    Text = "Booking in Monthly",
                    X = -20
                })

                .SetSubtitle(new Subtitle
                {
                    Text = "Source: Booking DB",
                    X = -20
                })
                .SetXAxis(new XAxis
                {
                    Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                })
                .SetYAxis(new YAxis
                {
                    Title = new YAxisTitle { Text = "จำนวน Booking", Style = "background: '#ffffff'" }
                })
                .SetSeries(new[]
                        {
                new Series
                {
                    Name = "แจ้งวัฒนะ",
                    Data = new Data(chartValues)   // Here we put the dbase data into the chart                   
                }
                    });


                container.InnerHtml = chart.ToHtmlString(); // Let's visualize the chart into the webform.
            }
            if (TypeGraph.Value == "Line")
            {
                DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts("chart").InitChart(new Chart { DefaultSeriesType = ChartTypes.Line })
                .SetTooltip(new Tooltip
                {
                    //HeaderFormat = "",
                    //PointFormat = "",
                    //FooterFormat = "",
                    //        <tr><td style="color:{series.color};padding:0">{series.name}: </ td > ' +
                    //'<td style="padding:0"><b>{point.y:.1f} mm</b></td></tr>'
                    Enabled = true,
                    UseHTML = true,
                    Shared = true
                })

                .SetPlotOptions(new PlotOptions
                {
                    Column = new PlotOptionsColumn
                    {
                        PointPadding = 0.2,
                        BorderWidth = 0
                    }
                })
                .SetTitle(new Title
                {
                    Text = "Booking in Monthly",
                    X = -20
                })

                .SetSubtitle(new Subtitle
                {
                    Text = "Source: Booking DB",
                    X = -20
                })
                .SetXAxis(new XAxis
                {
                    Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                })
                .SetYAxis(new YAxis
                {
                    Title = new YAxisTitle { Text = "จำนวน Booking", Style = "background: '#ffffff'" }
                })
                .SetSeries(new[]
                        {
                new Series
                {
                    Name = "แจ้งวัฒนะ",
                    Data = new Data(chartValues)   // Here we put the dbase data into the chart                   
                }
                    });


                container.InnerHtml = chart.ToHtmlString(); // Let's visualize the chart into the webform.
            }
            if (TypeGraph.Value == "Area")
            {
                DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts("chart").InitChart(new Chart { DefaultSeriesType = ChartTypes.Area })
                .SetTooltip(new Tooltip
                {
                    //HeaderFormat = "",
                    //PointFormat = "",
                    //FooterFormat = "",
                    //        <tr><td style="color:{series.color};padding:0">{series.name}: </ td > ' +
                    //'<td style="padding:0"><b>{point.y:.1f} mm</b></td></tr>'
                    Enabled = true,
                    UseHTML = true,
                    Shared = true
                })

                .SetPlotOptions(new PlotOptions
                {
                    Column = new PlotOptionsColumn
                    {
                        PointPadding = 0.2,
                        BorderWidth = 0
                    }
                })
                .SetTitle(new Title
                {
                    Text = "Booking in Monthly",
                    X = -20
                })

                .SetSubtitle(new Subtitle
                {
                    Text = "Source: Booking DB",
                    X = -20
                })
                .SetXAxis(new XAxis
                {
                    Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                })
                .SetYAxis(new YAxis
                {
                    Title = new YAxisTitle { Text = "จำนวน Booking", Style = "background: '#ffffff'" }
                })
                .SetSeries(new[]
                        {
                new Series
                {
                    Name = "แจ้งวัฒนะ",
                    Data = new Data(chartValues)   // Here we put the dbase data into the chart                   
                }
                    });


                container.InnerHtml = chart.ToHtmlString(); // Let's visualize the chart into the webform.
            }

        }
        protected void Render_Chartnk()
        {
            // Declare the SQL connection

            SqlConnection myConn = new SqlConnection(All_VG.sqlnk);
            // and add a query string for retrieving the data.
            //string commandText = "select period, count(pizza) from pizzaDB group by period order by period";
            string commandText = "SELECT MONTH(BOOKING_DATE) ,COUNT([BOOKING_NO]) FROM [Vgh-ids-Booking] where YEAR(BOOKING_DATE) = '" + CByear.Text + "' group by  MONTH(BOOKING_DATE) order by  MONTH(BOOKING_DATE) asc";
            SqlCommand myComm = new SqlCommand(commandText, myConn);
            // Open the connection
            myConn.Open();

            // and execute the query
            SqlDataReader reader = myComm.ExecuteReader();

            Object[] chartValues = new Object[12]; // declare an object for the chart rendering  
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    // GetValue() returns the data row from the query
                    // So:
                    //       GetValue(0) will contain the month number [<em>month(eaten_Pizza) as Mese</em>]
                    //       GetValue(1) will contain the number of eaten pizzas [<em>count(eaten_Pizza)</em>]

                    chartValues[(Int32)reader.GetValue(0) - 1] = reader.GetValue(1);
                    // minus 1 because the array starts from 0, whenever the months start from 1
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close(); // close the reader          

            // Declare the HighCharts object    
            if (TypeGraph.Value == "column") {
                DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts("chart").InitChart(new Chart { DefaultSeriesType = ChartTypes.Column })
                    .SetTooltip(new Tooltip
                    {
                    //HeaderFormat = "",
                    //PointFormat = "",
                    //FooterFormat = "",
                    //        <tr><td style="color:{series.color};padding:0">{series.name}: </ td > ' +
                    //'<td style="padding:0"><b>{point.y:.1f} mm</b></td></tr>'
                    Enabled = true,
                        UseHTML = true,
                        Shared = true
                    })

                    .SetPlotOptions(new PlotOptions
                    {
                        Column = new PlotOptionsColumn
                        {
                            PointPadding = 0.2,
                            BorderWidth = 0
                        }
                    })
                    .SetTitle(new Title
                    {
                        Text = "Booking in Monthly",
                        X = -20
                    })

                    .SetSubtitle(new Subtitle
                    {
                        Text = "Source: Booking DB",
                        X = -20
                    })
                    .SetXAxis(new XAxis
                    {
                        Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                    })
                    .SetYAxis(new YAxis
                    {
                        Title = new YAxisTitle { Text = "จำนวน Booking", Style = "background: '#ffffff'" }
                    })
                    .SetSeries(new[]
                            {
                new Series
                {
                    Name = "หนองแขม",
                    Data = new Data(chartValues)   // Here we put the dbase data into the chart                   
                }
                        });


                container.InnerHtml = chart.ToHtmlString(); // Let's visualize the chart into the webform.
            }
            if (TypeGraph.Value == "Line")
            {
                DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts("chart").InitChart(new Chart { DefaultSeriesType = ChartTypes.Line })
                    .SetTooltip(new Tooltip
                    {
                        //HeaderFormat = "",
                        //PointFormat = "",
                        //FooterFormat = "",
                        //        <tr><td style="color:{series.color};padding:0">{series.name}: </ td > ' +
                        //'<td style="padding:0"><b>{point.y:.1f} mm</b></td></tr>'
                        Enabled = true,
                        UseHTML = true,
                        Shared = true
                    })

                    .SetPlotOptions(new PlotOptions
                    {
                        Column = new PlotOptionsColumn
                        {
                            PointPadding = 0.2,
                            BorderWidth = 0
                        }
                    })
                    .SetTitle(new Title
                    {
                        Text = "Booking in Monthly",
                        X = -20
                    })

                    .SetSubtitle(new Subtitle
                    {
                        Text = "Source: Booking DB",
                        X = -20
                    })
                    .SetXAxis(new XAxis
                    {
                        Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                    })
                    .SetYAxis(new YAxis
                    {
                        Title = new YAxisTitle { Text = "จำนวน Booking", Style = "background: '#ffffff'" }
                    })
                    .SetSeries(new[]
                            {
                new Series
                {
                    Name = "หนองแขม",
                    Data = new Data(chartValues)   // Here we put the dbase data into the chart                   
                }
                        });


                container.InnerHtml = chart.ToHtmlString(); // Let's visualize the chart into the webform.
            }
            if (TypeGraph.Value == "Area")
            {
                DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts("chart").InitChart(new Chart { DefaultSeriesType = ChartTypes.Area })
                    .SetTooltip(new Tooltip
                    {
                        //HeaderFormat = "",
                        //PointFormat = "",
                        //FooterFormat = "",
                        //        <tr><td style="color:{series.color};padding:0">{series.name}: </ td > ' +
                        //'<td style="padding:0"><b>{point.y:.1f} mm</b></td></tr>'
                        Enabled = true,
                        UseHTML = true,
                        Shared = true
                    })

                    .SetPlotOptions(new PlotOptions
                    {
                        Column = new PlotOptionsColumn
                        {
                            PointPadding = 0.2,
                            BorderWidth = 0
                        }
                    })
                    .SetTitle(new Title
                    {
                        Text = "Booking in Monthly",
                        X = -20
                    })

                    .SetSubtitle(new Subtitle
                    {
                        Text = "Source: Booking DB",
                        X = -20
                    })
                    .SetXAxis(new XAxis
                    {
                        Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                    })
                    .SetYAxis(new YAxis
                    {
                        Title = new YAxisTitle { Text = "จำนวน Booking", Style = "background: '#ffffff'" }
                    })
                    .SetSeries(new[]
                            {
                new Series
                {
                    Name = "หนองแขม",
                    Data = new Data(chartValues)   // Here we put the dbase data into the chart                   
                }
                        });


                container.InnerHtml = chart.ToHtmlString(); // Let's visualize the chart into the webform.
            }

        }
        protected void Render_Chartbn()
        {
            // Declare the SQL connection

            SqlConnection myConn = new SqlConnection(All_VG.sqlbn);
            // and add a query string for retrieving the data.
            //string commandText = "select period, count(pizza) from pizzaDB group by period order by period";
            string commandText = "SELECT MONTH(BOOKING_DATE) ,COUNT([BOOKING_NO]) FROM [Vgh-ids-Booking] where YEAR(BOOKING_DATE) = '" + CByear.Text + "' group by  MONTH(BOOKING_DATE) order by  MONTH(BOOKING_DATE) asc";
            SqlCommand myComm = new SqlCommand(commandText, myConn);
            // Open the connection
            myConn.Open();

            // and execute the query
            SqlDataReader reader = myComm.ExecuteReader();

            Object[] chartValues = new Object[12]; // declare an object for the chart rendering  
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    // GetValue() returns the data row from the query
                    // So:
                    //       GetValue(0) will contain the month number [<em>month(eaten_Pizza) as Mese</em>]
                    //       GetValue(1) will contain the number of eaten pizzas [<em>count(eaten_Pizza)</em>]

                    chartValues[(Int32)reader.GetValue(0) - 1] = reader.GetValue(1);
                    // minus 1 because the array starts from 0, whenever the months start from 1
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close(); // close the reader          

            // Declare the HighCharts object 
            if (TypeGraph.Value == "column") {
                DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts("chart").InitChart(new Chart { DefaultSeriesType = ChartTypes.Column })
                    .SetTooltip(new Tooltip
                    {
                    //HeaderFormat = "",
                    //PointFormat = "",
                    //FooterFormat = "",
                    //        <tr><td style="color:{series.color};padding:0">{series.name}: </ td > ' +
                    //'<td style="padding:0"><b>{point.y:.1f} mm</b></td></tr>'
                    Enabled = true,
                        UseHTML = true,
                        Shared = true
                    })

                    .SetPlotOptions(new PlotOptions
                    {
                        Column = new PlotOptionsColumn
                        {
                            PointPadding = 0.2,
                            BorderWidth = 0
                        }
                    })
                    .SetTitle(new Title
                    {
                        Text = "Booking in Monthly",
                        X = -20
                    })

                    .SetSubtitle(new Subtitle
                    {
                        Text = "Source: Booking DB",
                        X = -20
                    })
                    .SetXAxis(new XAxis
                    {
                        Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                    })
                    .SetYAxis(new YAxis
                    {
                        Title = new YAxisTitle { Text = "จำนวน Booking", Style = "background: '#ffffff'" }
                    })
                    .SetSeries(new[]
                            {
                new Series
                {
                    Name = "บางกอกน้อย",
                    Data = new Data(chartValues)   // Here we put the dbase data into the chart                   
                }
                        });
                container.InnerHtml = chart.ToHtmlString(); // Let's visualize the chart into the webform.
            }
            // Declare the HighCharts object 
            if (TypeGraph.Value == "Line")
            {
                DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts("chart").InitChart(new Chart { DefaultSeriesType = ChartTypes.Line })
                    .SetTooltip(new Tooltip
                    {
                        //HeaderFormat = "",
                        //PointFormat = "",
                        //FooterFormat = "",
                        //        <tr><td style="color:{series.color};padding:0">{series.name}: </ td > ' +
                        //'<td style="padding:0"><b>{point.y:.1f} mm</b></td></tr>'
                        Enabled = true,
                        UseHTML = true,
                        Shared = true
                    })

                    .SetPlotOptions(new PlotOptions
                    {
                        Column = new PlotOptionsColumn
                        {
                            PointPadding = 0.2,
                            BorderWidth = 0
                        }
                    })
                    .SetTitle(new Title
                    {
                        Text = "Booking in Monthly",
                        X = -20
                    })

                    .SetSubtitle(new Subtitle
                    {
                        Text = "Source: Booking DB",
                        X = -20
                    })
                    .SetXAxis(new XAxis
                    {
                        Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                    })
                    .SetYAxis(new YAxis
                    {
                        Title = new YAxisTitle { Text = "จำนวน Booking", Style = "background: '#ffffff'" }
                    })
                    .SetSeries(new[]
                            {
                new Series
                {
                    Name = "บางกอกน้อย",
                    Data = new Data(chartValues)   // Here we put the dbase data into the chart                   
                }
                        });
                container.InnerHtml = chart.ToHtmlString(); // Let's visualize the chart into the webform.
            }
            // Declare the HighCharts object 
            if (TypeGraph.Value == "Area")
            {
                DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts("chart").InitChart(new Chart { DefaultSeriesType = ChartTypes.Area })
                    .SetTooltip(new Tooltip
                    {
                        //HeaderFormat = "",
                        //PointFormat = "",
                        //FooterFormat = "",
                        //        <tr><td style="color:{series.color};padding:0">{series.name}: </ td > ' +
                        //'<td style="padding:0"><b>{point.y:.1f} mm</b></td></tr>'
                        Enabled = true,
                        UseHTML = true,
                        Shared = true
                    })

                    .SetPlotOptions(new PlotOptions
                    {
                        Column = new PlotOptionsColumn
                        {
                            PointPadding = 0.2,
                            BorderWidth = 0
                        }
                    })
                    .SetTitle(new Title
                    {
                        Text = "Booking in Monthly",
                        X = -20
                    })

                    .SetSubtitle(new Subtitle
                    {
                        Text = "Source: Booking DB",
                        X = -20
                    })
                    .SetXAxis(new XAxis
                    {
                        Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                    })
                    .SetYAxis(new YAxis
                    {
                        Title = new YAxisTitle { Text = "จำนวน Booking", Style = "background: '#ffffff'" }
                    })
                    .SetSeries(new[]
                            {
                new Series
                {
                    Name = "บางกอกน้อย",
                    Data = new Data(chartValues)   // Here we put the dbase data into the chart                   
                }
                        });
                container.InnerHtml = chart.ToHtmlString(); // Let's visualize the chart into the webform.
            }

        }
        protected void Render_Chartpm()
        {
            // Declare the SQL connection

            SqlConnection myConn = new SqlConnection(All_VG.sqlpm);
            // and add a query string for retrieving the data.
            //string commandText = "select period, count(pizza) from pizzaDB group by period order by period";
            string commandText = "SELECT MONTH(BOOKING_DATE) ,COUNT([BOOKING_NO]) FROM [Vgh-ids-Booking] where YEAR(BOOKING_DATE) = '" + CByear.Text + "' group by  MONTH(BOOKING_DATE) order by  MONTH(BOOKING_DATE) asc";
            SqlCommand myComm = new SqlCommand(commandText, myConn);
            // Open the connection
            myConn.Open();

            // and execute the query
            SqlDataReader reader = myComm.ExecuteReader();

            Object[] chartValues = new Object[12]; // declare an object for the chart rendering  
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    // GetValue() returns the data row from the query
                    // So:
                    //       GetValue(0) will contain the month number [<em>month(eaten_Pizza) as Mese</em>]
                    //       GetValue(1) will contain the number of eaten pizzas [<em>count(eaten_Pizza)</em>]

                    chartValues[(Int32)reader.GetValue(0) - 1] = reader.GetValue(1);
                    // minus 1 because the array starts from 0, whenever the months start from 1
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close(); // close the reader          

            // Declare the HighCharts object    
            if (TypeGraph.Value == "column") {
                DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts("chart").InitChart(new Chart { DefaultSeriesType = ChartTypes.Column })
                    .SetTooltip(new Tooltip
                    {
                    //HeaderFormat = "",
                    //PointFormat = "",
                    //FooterFormat = "",
                    //        <tr><td style="color:{series.color};padding:0">{series.name}: </ td > ' +
                    //'<td style="padding:0"><b>{point.y:.1f} mm</b></td></tr>'
                    Enabled = true,
                        UseHTML = true,
                        Shared = true
                    })

                    .SetPlotOptions(new PlotOptions
                    {
                        Column = new PlotOptionsColumn
                        {
                            PointPadding = 0.2,
                            BorderWidth = 0
                        }
                    })
                    .SetTitle(new Title
                    {
                        Text = "Booking in Monthly",
                        X = -20
                    })

                    .SetSubtitle(new Subtitle
                    {
                        Text = "Source: Booking DB",
                        X = -20
                    })
                    .SetXAxis(new XAxis
                    {
                        Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                    })
                    .SetYAxis(new YAxis
                    {
                        Title = new YAxisTitle { Text = "จำนวน Booking", Style = "background: '#ffffff'" }
                    })
                    .SetSeries(new[]
                            {
                new Series
                {
                    Name = "ปากเกร็ด-เมืองทอง",
                    Data = new Data(chartValues)   // Here we put the dbase data into the chart                   
                }
                        });


                container.InnerHtml = chart.ToHtmlString(); // Let's visualize the chart into the webform.
            }
            if (TypeGraph.Value == "Line")
            {
                DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts("chart").InitChart(new Chart { DefaultSeriesType = ChartTypes.Line })
                    .SetTooltip(new Tooltip
                    {
                        //HeaderFormat = "",
                        //PointFormat = "",
                        //FooterFormat = "",
                        //        <tr><td style="color:{series.color};padding:0">{series.name}: </ td > ' +
                        //'<td style="padding:0"><b>{point.y:.1f} mm</b></td></tr>'
                        Enabled = true,
                        UseHTML = true,
                        Shared = true
                    })

                    .SetPlotOptions(new PlotOptions
                    {
                        Column = new PlotOptionsColumn
                        {
                            PointPadding = 0.2,
                            BorderWidth = 0
                        }
                    })
                    .SetTitle(new Title
                    {
                        Text = "Booking in Monthly",
                        X = -20
                    })

                    .SetSubtitle(new Subtitle
                    {
                        Text = "Source: Booking DB",
                        X = -20
                    })
                    .SetXAxis(new XAxis
                    {
                        Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                    })
                    .SetYAxis(new YAxis
                    {
                        Title = new YAxisTitle { Text = "จำนวน Booking", Style = "background: '#ffffff'" }
                    })
                    .SetSeries(new[]
                            {
                new Series
                {
                    Name = "ปากเกร็ด-เมืองทอง",
                    Data = new Data(chartValues)   // Here we put the dbase data into the chart                   
                }
                        });


                container.InnerHtml = chart.ToHtmlString(); // Let's visualize the chart into the webform.
            }
            if (TypeGraph.Value == "Area")
            {
                DotNet.Highcharts.Highcharts chart = new DotNet.Highcharts.Highcharts("chart").InitChart(new Chart { DefaultSeriesType = ChartTypes.Area })
                    .SetTooltip(new Tooltip
                    {
                        //HeaderFormat = "",
                        //PointFormat = "",
                        //FooterFormat = "",
                        //        <tr><td style="color:{series.color};padding:0">{series.name}: </ td > ' +
                        //'<td style="padding:0"><b>{point.y:.1f} mm</b></td></tr>'
                        Enabled = true,
                        UseHTML = true,
                        Shared = true
                    })

                    .SetPlotOptions(new PlotOptions
                    {
                        Column = new PlotOptionsColumn
                        {
                            PointPadding = 0.2,
                            BorderWidth = 0
                        }
                    })
                    .SetTitle(new Title
                    {
                        Text = "Booking in Monthly",
                        X = -20
                    })

                    .SetSubtitle(new Subtitle
                    {
                        Text = "Source: Booking DB",
                        X = -20
                    })
                    .SetXAxis(new XAxis
                    {
                        Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                    })
                    .SetYAxis(new YAxis
                    {
                        Title = new YAxisTitle { Text = "จำนวน Booking", Style = "background: '#ffffff'" }
                    })
                    .SetSeries(new[]
                            {
                new Series
                {
                    Name = "ปากเกร็ด-เมืองทอง",
                    Data = new Data(chartValues)   // Here we put the dbase data into the chart                   
                }
                        });


                container.InnerHtml = chart.ToHtmlString(); // Let's visualize the chart into the webform.
            }

        }

        protected void TypeGraph_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBtypeselect.Text = "Booking New Cars";
            CBoutlet.Value = "ทั้งหมด";
            CByear.Value = "2019";
            Render_Chart();
        }
    }
}