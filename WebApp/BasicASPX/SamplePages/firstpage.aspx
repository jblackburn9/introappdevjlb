<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="firstpage.aspx.cs" Inherits="BasicASPX.SamplePages.firstpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>

public partial class FirstPage :
System.Web.UI.Page
{
    protected void Page_Load(object sender, Eventargs e)
    {
        //this method is executed on each and every pass of the page
        //this method happens before any events
    }
    
    protected void PressMe_Click(object sender, EventArgs e)
    {
        output.Text = "hello there " + yourname.Text;
    }
