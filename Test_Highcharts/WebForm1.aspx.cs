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

namespace Test_Highcharts
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Render_Chart();
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
            string commandTextpm = "SELECT MONTH(BOOKING_DATE) ,COUNT([BOOKING_NO]) FROM [Vgh-ids-Booking] where YEAR(BOOKING_DATE) = '2019' group by  MONTH(BOOKING_DATE) order by  MONTH(BOOKING_DATE) asc";
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
            string commandTextcw = "SELECT MONTH(BOOKING_DATE) ,COUNT([BOOKING_NO]) FROM [Vgh-ids-Booking] where YEAR(BOOKING_DATE) = '2019' group by  MONTH(BOOKING_DATE) order by  MONTH(BOOKING_DATE) asc";
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
            string commandTextnk = "SELECT MONTH(BOOKING_DATE) ,COUNT([BOOKING_NO]) FROM [Vgh-ids-Booking] where YEAR(BOOKING_DATE) = '2019' group by  MONTH(BOOKING_DATE) order by  MONTH(BOOKING_DATE) asc";
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
            string commandTextbn = "SELECT MONTH(BOOKING_DATE) ,COUNT([BOOKING_NO]) FROM [Vgh-ids-Booking] where YEAR(BOOKING_DATE) = '2019' group by  MONTH(BOOKING_DATE) order by  MONTH(BOOKING_DATE) asc";
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
    }
    
}