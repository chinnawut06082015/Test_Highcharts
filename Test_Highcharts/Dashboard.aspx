<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Test_Highcharts.Dashboard" %>

<%@ Register Assembly="DevExpress.Web.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="icon" href="/docs/4.0/assets/img/favicons/favicon.ico">
    <script src="js/highcharts.js"></script>
    <script src="scripts/Highcharts-4.0.1/js/modules/exporting.js"></script>

    <title>Dashboard for Sale</title>

    <%--<link rel="canonical" href="https://getbootstrap.com/docs/4.0/examples/dashboard/">--%>

    <!-- Bootstrap core CSS -->
    <%--    <link href="../../dist/css/bootstrap.min.css" rel="stylesheet">--%>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="scripts/jquery-3.0.0.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <script src="scripts/jquery-3.0.0.slim.min.js"></script>

    <!-- Custom styles for this template -->
    <%-- <link href="dashboard.css" rel="stylesheet">--%>
  <style type="text/css">/* Chart.js */
@-webkit-keyframes chartjs-render-animation{from{opacity:0.99}to{opacity:1}}@keyframes chartjs-render-animation{from{opacity:0.99}to{opacity:1}}.chartjs-render-monitor{-webkit-animation:chartjs-render-animation 0.001s;animation:chartjs-render-animation 0.001s;}</style></head>
<body>
    <nav class="navbar navbar-light" style="background-color: #e3f2fd;" sticky-top flex-md-nowrap p-0">
      <a class="navbar-brand col-sm-3 col-md-2 mr-0" style ="font-size:large">
          <img src="img/favicon.ico" width="30" height="30" alt="">
          <strong>Vgroup Honda Cars</strong></a>    
    </nav>
    <form id="form1" runat="server">
    <div class="container-fluid">
      <div class="row">
        <nav class="col-md-2 d-none d-md-block bg-light sidebar">
          <div class="sidebar-sticky">
            <ul class="nav flex-column">
              <li class="nav-item">
                <a class="nav-link active">                 
                  Dashboard <span class="sr-only">(current)</span>
                </a>
                
              </li>
              <li class="nav-item">
                  <%--<input type="button" onserverclick="btn_click" runat="server" value="Login" class="btn float-right login_btn">--%>
                <a class="nav-link" runat ="server" onserverclick ="Unnamed_ServerClick">                  
                  Booking View
                </a>
              </li>
              <%--<li class="nav-item">
                <a class="nav-link" href="#">
                   Products
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="#">
                  Customers
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="#">
                  Reports
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="#">
                 Integrations
                </a>
              </li>--%>
            </ul>

            <%--<h6 class="sidebar-heading d-flex justify-content-between align-items-center px-3 mt-4 mb-1 text-muted">
              <span>Saved reports</span>
              <a class="d-flex align-items-center text-muted" href="#">
                <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-plus-circle"><circle cx="12" cy="12" r="10"></circle><line x1="12" y1="8" x2="12" y2="16"></line><line x1="8" y1="12" x2="16" y2="12"></line></svg>
              </a>
            </h6>
            <ul class="nav flex-column mb-2">
              <li class="nav-item">
                <a class="nav-link" href="#">
                  <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-file-text"><path d="M14 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V8z"></path><polyline points="14 2 14 8 20 8"></polyline><line x1="16" y1="13" x2="8" y2="13"></line><line x1="16" y1="17" x2="8" y2="17"></line><polyline points="10 9 9 9 8 9"></polyline></svg>
                  Current month
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="#">
                  <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-file-text"><path d="M14 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V8z"></path><polyline points="14 2 14 8 20 8"></polyline><line x1="16" y1="13" x2="8" y2="13"></line><line x1="16" y1="17" x2="8" y2="17"></line><polyline points="10 9 9 9 8 9"></polyline></svg>
                  Last quarter
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="#">
                  <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-file-text"><path d="M14 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V8z"></path><polyline points="14 2 14 8 20 8"></polyline><line x1="16" y1="13" x2="8" y2="13"></line><line x1="16" y1="17" x2="8" y2="17"></line><polyline points="10 9 9 9 8 9"></polyline></svg>
                  Social engagement
                </a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="#">
                  <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-file-text"><path d="M14 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V8z"></path><polyline points="14 2 14 8 20 8"></polyline><line x1="16" y1="13" x2="8" y2="13"></line><line x1="16" y1="17" x2="8" y2="17"></line><polyline points="10 9 9 9 8 9"></polyline></svg>
                  Year-end sale
                </a>
              </li>
            </ul>--%>
          </div>
        </nav>

        <main role="main" class="col-md-9 ml-sm-auto col-lg-10 pt-3 px-4"><div class="chartjs-size-monitor" style="position: absolute; left: 0px; top: 0px; right: 0px; bottom: 0px; overflow: hidden; pointer-events: none; visibility: hidden; z-index: -1;"><div class="chartjs-size-monitor-expand" style="position:absolute;left:0;top:0;right:0;bottom:0;overflow:hidden;pointer-events:none;visibility:hidden;z-index:-1;"><div style="position:absolute;width:1000000px;height:1000000px;left:0;top:0"></div></div><div class="chartjs-size-monitor-shrink" style="position:absolute;left:0;top:0;right:0;bottom:0;overflow:hidden;pointer-events:none;visibility:hidden;z-index:-1;"><div style="position:absolute;width:200%;height:200%;left:0; top:0"></div></div></div>
          <div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pb-2 mb-3 border-bottom">
            <h1 class="h2">Dashboard</h1>
              <dx:ASPxLabel ID="LBtypeselect" runat="server" Font-Bold="True" Font-Size="Large" Theme="iOS"></dx:ASPxLabel>
            <div class="btn-toolbar mb-2 mb-md-0">

                <dx:ASPxComboBox ID="TypeGraph" runat="server" Theme="iOS" Caption="ประเภทกราฟ" EnableTheming="True" SelectedIndex="0" AutoPostBack="True" OnSelectedIndexChanged="TypeGraph_SelectedIndexChanged">
                    <Items>
                        <dx:ListEditItem Text="colunm" Value="colunm" Selected="True" />
                        <dx:ListEditItem Text="Line" Value="Line" /> 
                        <dx:ListEditItem Text="Area" Value="Area" />    
                    </Items>
                    <CaptionSettings HorizontalAlign="Center" VerticalAlign="Middle" />
                    <CaptionStyle Font-Bold="True" Font-Size="Medium">
                    </CaptionStyle>
                </dx:ASPxComboBox>

                &nbsp;&nbsp;&nbsp;

                <dx:ASPxComboBox ID="CByear" runat="server" Theme="iOS" Caption="ปี" EnableTheming="True" SelectedIndex="0">
                    <Items>
                        <dx:ListEditItem Text="2019" Value="2019" Selected="True" />
                        <dx:ListEditItem Text="2020" Value="2020" />
                        <dx:ListEditItem Text="2021" Value="2021" />
                        <dx:ListEditItem Text="2022" Value="2022" />
                        <dx:ListEditItem Text="2023" Value="2023" />
                    </Items>
                    <CaptionSettings HorizontalAlign="Center" VerticalAlign="Middle" />
                    <CaptionStyle Font-Bold="True" Font-Size="Medium">
                    </CaptionStyle>
                </dx:ASPxComboBox>

                &nbsp;&nbsp;&nbsp;

                <dx:ASPxComboBox ID="CBoutlet" runat="server" Theme="iOS" AutoPostBack="True" Caption="สาขา" EnableTheming="True" OnSelectedIndexChanged="CBoutlet_SelectedIndexChanged">
                    <Items>
                        <dx:ListEditItem Text="ทั้งหมด" Value="ทั้งหมด" />
                        <dx:ListEditItem Text="0112" Value="0112" />
                        <dx:ListEditItem Text="0113" Value="0113" />
                        <dx:ListEditItem Text="0115" Value="0115" />
                        <dx:ListEditItem Text="0116" Value="0116" />
                    </Items>
                    <CaptionSettings HorizontalAlign="Center" VerticalAlign="Middle" />
                    <CaptionStyle Font-Bold="True" Font-Size="Medium">
                    </CaptionStyle>
                </dx:ASPxComboBox>
                
                <%--<div class="dropdown">
                  <button class="btn btn-secondary dropdown-toggle" runat="server" type="button" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                    Dropdown button
                  </button>
                  <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                    <a class="dropdown-item" href="#">Action</a>
                    <a class="dropdown-item" href="#">Another action</a>
                    <a class="dropdown-item" href="#">Something else here</a>
                  </div>
                </div>--%><%--<div class="btn-group mr-2">
                <button class="btn btn-sm btn-outline-secondary">Share</button>
                <button class="btn btn-sm btn-outline-secondary">Export</button>
              </div>
              <button class="btn btn-sm btn-outline-secondary dropdown-toggle">
                <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-calendar"><rect x="3" y="4" width="18" height="18" rx="2" ry="2"></rect><line x1="16" y1="2" x2="16" y2="6"></line><line x1="8" y1="2" x2="8" y2="6"></line><line x1="3" y1="10" x2="21" y2="10"></line></svg>
                This week
              </button>--%>
            </div>
          </div>

          <%--<canvas class="my-4 chartjs-render-monitor" id="myChart" width="1049" height="442" style="display: block; width: 1049px; height: 442px;"></canvas>--%>
            <div id="container" width="1049" height="442" style="min-width: 310px; height: 442px; margin: 0 auto"  runat="server"></div>
          <%--<div id="Div1" style="min-width: 310px; height: 400px; margin: 0 auto"  runat="server"></div>--%>

          <h2>Section title</h2>
          <div >
              <dx:ASPxGridView ID="GVshow0" runat="server" AutoGenerateColumns="False" EnableTheming="True" Theme="iOS" Visible="False">
                  <SettingsPager Mode="ShowAllRecords" Visible="False">
                  </SettingsPager>
                  <Settings ShowGroupPanel="True" />
                  <Columns>
                      <dx:GridViewDataTextColumn Caption="สาขา" FieldName="DEALER_CODE" VisibleIndex="0">
                          <HeaderStyle Font-Bold="True" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
                          <CellStyle Font-Bold="False" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False">
                          </CellStyle>
                      </dx:GridViewDataTextColumn>
                      <dx:GridViewDataTextColumn Caption="BOOKING_NO" FieldName="BOOKING_NO" VisibleIndex="1">
                          <HeaderStyle Font-Bold="True" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
                          <CellStyle Font-Bold="False" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False">
                          </CellStyle>
                      </dx:GridViewDataTextColumn>
                      <dx:GridViewDataTextColumn Caption="BOOKING_DATE" FieldName="BOOKING_DATE" VisibleIndex="2">
                          <HeaderStyle Font-Bold="True" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
                          <CellStyle Font-Bold="False" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False">
                          </CellStyle>
                      </dx:GridViewDataTextColumn>
                      <dx:GridViewDataTextColumn Caption="รุ่นรถยนต์" FieldName="SERIES_NAME" VisibleIndex="3">
                          <HeaderStyle Font-Bold="True" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
                          <CellStyle Font-Bold="False" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False">
                          </CellStyle>
                      </dx:GridViewDataTextColumn>
                      <dx:GridViewDataTextColumn Caption="MODEL_GRADE" FieldName="MODEL_GRADE" VisibleIndex="4">
                          <HeaderStyle Font-Bold="True" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
                          <CellStyle Font-Bold="False" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False">
                          </CellStyle>
                      </dx:GridViewDataTextColumn>
                      <dx:GridViewDataTextColumn Caption="MODEL_YEAR" FieldName="MODEL_YEAR" VisibleIndex="5">
                          <HeaderStyle Font-Bold="True" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
                          <CellStyle Font-Bold="False" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False">
                          </CellStyle>
                      </dx:GridViewDataTextColumn>
                      <dx:GridViewDataTextColumn FieldName="MODEL_COLOR" VisibleIndex="6">
                          <HeaderStyle Font-Bold="True" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
                          <CellStyle Font-Bold="False" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False">
                          </CellStyle>
                      </dx:GridViewDataTextColumn>
                      <dx:GridViewDataTextColumn Caption="หมายเลขลูกค้า" FieldName="BOOK_CUSTOMER_NO" VisibleIndex="7">
                          <HeaderStyle Font-Bold="True" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
                          <CellStyle Font-Bold="False" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False">
                          </CellStyle>
                      </dx:GridViewDataTextColumn>
                      <dx:GridViewDataTextColumn Caption="คำนำหน้า" FieldName="BOOK_CUS_SIR_NAME" VisibleIndex="8">
                          <HeaderStyle Font-Bold="True" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
                          <CellStyle Font-Bold="False" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False">
                          </CellStyle>
                      </dx:GridViewDataTextColumn>
                      <dx:GridViewDataTextColumn Caption="ชื่อ" FieldName="BOOK_CUS_FIRST_NAME" VisibleIndex="9">
                          <HeaderStyle Font-Bold="True" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
                          <CellStyle Font-Bold="False" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False">
                          </CellStyle>
                      </dx:GridViewDataTextColumn>
                      <dx:GridViewDataTextColumn Caption="สกุล" FieldName="BOOK_CUS_LAST_NAME" VisibleIndex="10">
                          <HeaderStyle Font-Bold="True" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
                          <CellStyle Font-Bold="False" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False">
                          </CellStyle>
                      </dx:GridViewDataTextColumn>
                      <dx:GridViewDataTextColumn Caption="STAFF_CODE" FieldName="STAFF_CODE" VisibleIndex="11">
                          <HeaderStyle Font-Bold="True" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
                          <CellStyle Font-Bold="False" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False">
                          </CellStyle>
                      </dx:GridViewDataTextColumn>
                      <dx:GridViewDataTextColumn Caption="STAFF_FIRST_NAME" FieldName="STAFF_FIRST_NAME" VisibleIndex="12">
                          <HeaderStyle Font-Bold="True" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
                          <CellStyle Font-Bold="False" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False">
                          </CellStyle>
                      </dx:GridViewDataTextColumn>
                      <dx:GridViewDataTextColumn Caption="STAFF_LAST_NAME" FieldName="STAFF_LAST_NAME" VisibleIndex="13">
                          <HeaderStyle Font-Bold="True" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
                          <CellStyle Font-Bold="False" Font-Size="X-Small" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False">
                          </CellStyle>
                      </dx:GridViewDataTextColumn>
                  </Columns>
                  <Styles>
                      <GroupPanel Font-Bold="True" Font-Size="Small">
                      </GroupPanel>
                      <HeaderFilterItem Font-Size="Small">
                      </HeaderFilterItem>
                  </Styles>
              </dx:ASPxGridView>
          </div>
        </main>
      </div>
    </div>
    </form>
</body>
</html>
