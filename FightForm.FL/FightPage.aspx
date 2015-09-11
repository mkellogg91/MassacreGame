<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FightPage.aspx.cs" Inherits="FightForm.FL.FightPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        <div>

            <asp:Label ID="Label2" runat="server" Text="# of warriors to fight: " ></asp:Label>
            <asp:TextBox ID="warriorNumber" runat="server" Text ="1" ></asp:TextBox>

        </div>

        </br>
        </br>

        <div>
    
            <asp:Label ID="Label1" runat="server" Text="FightBox: "></asp:Label>
            <asp:TextBox ID="FightText" runat="server" Height="575px" Width="1014px" enabled="false" TextMode="MultiLine"></asp:TextBox>
    
        </div>

        </br>
        </br>

        <div>

            <asp:Button ID="fightButton" runat="server" Text="Fight!" OnClick="fightButton_Click" />

        </div>


    </form>
</body>
</html>
