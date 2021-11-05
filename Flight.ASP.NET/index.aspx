<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Flight.ASP.NET.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP.NET</title>
    
    <style type="text/css">
.auto-style1 {
text-align: center;
color: saddlebrown;
}
.auto-style2 {
width: 417px;
}
.auto-style6 {
width: 273px;

}
.auto-style7 {
height: 55px;
width: 273px;
}
.auto-style9 {
width: 733px;
height: 581px;
}
.auto-style10 {
width: 97px;
}
.auto-style11 {
width: 500px;
}
.auto-style12 {
height: 116px;
}
.stylePanel {
border-radius:50px;
}
.tecboc {
border-radius:10px;
}
        #TextArea1 {
            width: 448px;
            height: 71px;
        }
        .auto-style16 {
            width: 97px;
            height: 29px;
        }
        .auto-style17 {
            width: 273px;
            height: 29px;
        }
    </style>
</head>
<body style="background-color:antiquewhite">
    <form id="form1" runat="server" class="auto-style9" >
        <div><h1 class="auto-style2"> Flight Application </h1></div>
        <hr class="auto-style2" />
        <table class="auto-style11">
            <tr "vertical-align:top">
                <td class="auto-style12">
                    <asp:Panel ID="Panelinfo" runat="server" CssClass="stylePanel" BackColor="#CC9900"
                        GroupingText="flight info" Height="100%" Width="45%">
                        <table class="auto-style12">
                            <tr>
                                <td class="auto-style16">
                                    <asp:Label ID="Labelname" runat="server" Text="Full name" AccessKey="c" 
                                        AssociatedControlID="txtName"> </asp:Label>
                                  
                                </td>
                                <td class="auto-style17">
                                    <asp:TextBox ID="txtName" runat="server" CssClass="tecboc" Width="200px"
                                        OnTextChanged="txtName_TextChanged"></asp:TextBox>
                                       
                                </td>

                            </tr>
                            <tr>
                                <td class="auto-style10">
                                    <asp:Label ID="Labelgender" runat="server" Text="Gender"></asp:Label>
                                </td>
                                <td class="auto-style7">
                                    <asp:RadioButtonList ID="radlistgender" runat="server" AutoPostBack="true"></asp:RadioButtonList>
                                       
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">
                                    <asp:Label ID="Labelfrom" runat="server" Text="From City"></asp:Label>
                                </td>
                                <td class="auto-style10">
                                    <asp:DropDownList ID="cbocity" runat="server" CssClass="tecboc" AutoPostBack="true"
                                         Width="200px"></asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">
                                    <asp:Label ID="Labeldist" runat="server" Text="Distanation"></asp:Label>
                                </td>
                                <td class="auto-style6">
                                    <asp:ListBox ID="listdist" runat="server" AutoPostBack="true" Width="105px" ></asp:ListBox>
                                      
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Labeldatetime" runat="server" Text="Which day and when?"
                                        CssClass="tecboc" Width="200px"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtdattime" runat="server" TextMode="DateTimeLocal" OnTextChanged="txtdattime_TextChanged"></asp:TextBox>

                                </td>
                            </tr>
                              <tr>
                                <td class="auto-style10">
                                    <asp:Label ID="Labeltrip" runat="server" Text="Trip"></asp:Label>
                                </td>
                                <td class="auto-style7">
                                    <asp:RadioButtonList ID="radlisttrip" runat="server" AutoPostBack="true"></asp:RadioButtonList>
                                        
                                </td>
                            </tr>
                              <tr>
                                <td class="auto-style10">
                                    <asp:Label ID="Labelclass" runat="server" Text="Class Flight"></asp:Label>
                                </td>
                                <td class="auto-style6">
                                    <asp:ListBox ID="ListBoxfclass" runat="server" AutoPostBack="true" Width="105px"></asp:ListBox>
                                        
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">
                                    <asp:Label ID="Labelservice" runat="server" Text="Service Extra"></asp:Label>
                                </td>
                                <td class="auto-style6">
                                    <asp:CheckBoxList ID="chkboxlisservice" runat="server" AutoPostBack="true"
                                         Width="105px"></asp:CheckBoxList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">
                                    <asp:Label ID="LabelElctTicket" runat="server" Text="Elect Ticket"></asp:Label>
                                </td>
                                <td class="auto-style6">
                                    <asp:CheckBox ID="chEmail" runat="server" AutoPostBack="true"/>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">
                                    <asp:Label ID="Labelemail" runat="server" Text="Email Adress"></asp:Label>

                                </td >
                                <td class="auto-style7">
                                    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="tecboc" Width="200px"></asp:TextBox>
                                </td>
                            </tr>
                           
                           
                        </table>
                    </asp:Panel>

                </td>
                <td class="auto-style12">
                    <asp:Panel ID="Panelpricing" runat="server" CssClass="auto-style1" 
                        GroupingText="pricing" BackColor="#CC9900" Height="100%" Width="260px">
                        <asp:Literal ID="litprice" runat="server"></asp:Literal>
                        <asp:Button ID="btncon" runat="server" Text="Conclude"  OnClick="btncon_Click" />
                    </asp:Panel>
                </td>
                <td class="auto-style12">
                    <asp:Panel ID="Panelfinal" runat="server" CssClass="auto-style1"
                        GroupingText="Final Information" BackColor="#CC9900" Height="100%" Width="260px">
                        <asp:Literal ID="litfinal" runat="server"></asp:Literal>
                    </asp:Panel>

                </td>
                 
           

        </table>

    </form>
   
</body>
</html>
