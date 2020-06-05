<%@ Page Title="" Language="C#" MasterPageFile="~/Faculty/Faculty.master" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="Faculty_Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- Content Header (Page header) -->
    <div class="content-header">
        <h1>Dashboard<small></small></h1>
            <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
            <li class="active">Dashboard</li>
        </ol>
    </div>
    <!-- Main content -->
    <div class="content">
        <!-- Small boxes (Stat box) -->
        <div class="row">
                      
            <div class="col-lg-3 col-xs-6">
                <!-- small box -->
                 <div class="small-box bg-aqua">
                    <div class="inner">
                        <h3 id="students" runat="server">0</h3>
                        <p> Total Registered Students</p>
                    </div>
                    <div class="icon">
                        <i class="fa fa-users"></i>
                    </div>
                    <a href="ManageStudents.aspx" class="small-box-footer">
                        View Details <i class="fa fa-arrow-circle-right"></i>
                    </a>
                </div>
            </div><!-- ./col --> 
          
                                      
        </div>                 
    </div>
</asp:Content>

