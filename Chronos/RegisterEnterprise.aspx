<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterEnterprise.aspx.cs" Inherits="Chronos.RegisterEnterprise" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $('#MainContent_txtNascimento').datepicker({
                format: 'dd/mm/yyyy'
            });
        });
    

    </script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">




    <p>
    <br />
    <asp:MultiView ID="RegisterMultiPanel" runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server">
            <h1>Cadastro para propaganda:</h1>
        
            <div class="well form-inline">
       

             <div class="control-group">
                <label for="txtNome" class="control-label">Razão Social&nbsp; </label>
                 :
                <div class="controls">
                      <asp:TextBox ID="txtRazao"  placeholder="Nome" runat="server" 
                          class="input-medium" MaxLength="40" ontextchanged="txtNome_TextChanged"></asp:TextBox>
                      <br />
                      <asp:Label ID="msgRazao" runat="server" Font-Italic="False" Font-Size="Smaller" 
                          ForeColor="Red" Visible="False"></asp:Label>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      </div>
             </div>
              
              <div class="control-group">
                <label for="txtEmail" class="control-label">Nome Fantasia:</label>
                <div class="controls">
                  <span class="add-on"></i></span>
                  <asp:TextBox ID="txtFantasia" placeholder="Nome Fantasia" runat="server" 
                        class="input-xlarge" MaxLength="80"></asp:TextBox>
                    <br />
                    <asp:Label ID="msgFantasia" runat="server" Font-Italic="False" Font-Size="Smaller" 
                        ForeColor="Red" Visible="False"></asp:Label>
                </div>
             </div>
             <div class="control-group">
                <label for="txtEmail2" class="control-label">&nbsp;E-mail:</label>
                <div class="controls">
                  <span class="add-on"><i class="icon-envelope"></i></span>
                  <asp:TextBox ID="txtEmail2" placeholder="E-mail" runat="server" 
                        class="input-xlarge" MaxLength="80"></asp:TextBox>
                    <br />
                    <asp:Label ID="msgEmail" runat="server" Font-Italic="False" 
                        Font-Size="Smaller" ForeColor="Red" Visible="False"></asp:Label>
                </div>
             </div>
             <div class="control-group">
                <label for="txtEmail2" class="control-label">&nbsp;Confirme o E-mail:</label>
                <div class="controls">
                  <span class="add-on"><i class="icon-envelope"></i></span>
                  <asp:TextBox data-date-format="mm/dd/yy" placeholder="E-mail" 
                        ID="txtNascimento" runat="server" class="input-medium" MaxLength="10"></asp:TextBox>
                    <br />
                    <asp:Label ID="msgEmail2" runat="server" Font-Italic="False" 
                        Font-Size="Smaller" ForeColor="Red" Visible="False"></asp:Label>
                </div>
             </div>
             <div class="control-group">
                <label for="txtEmail2" class="control-label">&nbsp; Site:</label>
                <div class="controls">
                  <asp:TextBox data-date-format="mm/dd/yy" ID="txtSite" runat="server" 
                        TextMode="Password" class="input-medium" MaxLength="40"></asp:TextBox>
                    <br />
                    <asp:Label ID="msgSite" runat="server" Font-Italic="False" 
                        Font-Size="Smaller" ForeColor="Red" Visible="False"></asp:Label>
                </div>
             </div>
             <div class="control-group">
                <label for="txtEmail2" class="control-label">&nbsp;Senha:</label>
                <div class="controls">
                  <asp:TextBox data-date-format="mm/dd/yy" ID="Password" runat="server" class="input-medium" 
                        TextMode="Password" MaxLength="40"></asp:TextBox>
                    <br />
                    <asp:Label ID="msgPassword" runat="server" Font-Italic="False" 
                        Font-Size="Smaller" ForeColor="Red" Visible="False"></asp:Label>
                </div>
             </div>

                 <label class="control-label" for="txtEmail2">
                &nbsp;Confirme a Senha:</label>
                <div class="controls">
                    <asp:TextBox ID="Password2" runat="server" class="input-medium" 
                        data-date-format="mm/dd/yy" MaxLength="40" TextMode="Password"></asp:TextBox>
                    <br />
                    <asp:Label ID="msgPassword2" runat="server" Font-Italic="False" 
                        Font-Size="Smaller" ForeColor="Red" Visible="False"></asp:Label>
                </div>
                <label class="control-label" for="txtEmail2">
                &nbsp;Descrição:</label>
                <div class="controls">
                    <textarea ID="txtDescricao" name="S1"></textarea><br />
                    <asp:Label ID="msgDescricao" runat="server" Font-Italic="False" 
                        Font-Size="Smaller" ForeColor="Red" Visible="False"></asp:Label>
                </div>

                 <p>
                     &nbsp;</p>
                 <p>
                     <asp:Button ID="registra" runat="server" class="btn btn-primary btn-large" 
                         onclick="Button1_Click" Text="Button" />
                </p>
                 <p>
                     &nbsp;</p>
                 </div>
        </asp:View>
        <asp:View ID="View2" runat="server">
            <br />
        </asp:View>
    </asp:MultiView>
</p>
<p>
</p>




</asp:Content>
