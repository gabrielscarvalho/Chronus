<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Chronos.register" %>
<asp:Content ID="register" ContentPlaceHolderID="HeadContent" runat="server">
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
            <h1>Cadastre-se</h1>
        
            <div class="well form-inline">
       

             <div class="control-group">
                <label for="txtNome" class="control-label">&nbsp;Nome Completo:</label>
                <div class="controls">
                      <asp:TextBox ID="txtNome"  placeholder="Nome" runat="server" class="input-medium"></asp:TextBox>
                      <asp:TextBox ID="txtSobrenome"  placeholder="Sobrenome" runat="server" class="input-medium"></asp:TextBox>
                </div>
             </div>
              
              <div class="control-group">
                <label for="txtEmail" class="control-label">&nbsp;E-mail:</label>
                <div class="controls">
                  <span class="add-on"><i class="icon-envelope"></i></span>
                  <asp:TextBox ID="txtEmail" placeholder="E-mail" runat="server" class="input-xlarge"></asp:TextBox>
                </div>
             </div>
            <div class="control-group">
                <label for="txtEmail2" class="control-label">&nbsp;Repita o E-mail:</label>
                <div class="controls">
                  <span class="add-on"><i class="icon-envelope"></i></span>
                  <asp:TextBox ID="txtEmail2" placeholder="E-mail" runat="server" class="input-xlarge"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblEmail" runat="server" ForeColor="Red" Visible="False"></asp:Label>
                </div>
             </div>
               <div class="control-group">
                <label for="txtEmail" class="control-label">&nbsp;Sexo:</label>
                <div class="controls">
                  <span class="add-on"></span>
                  
                    <asp:DropDownList ID="txtSexo" runat="server">
                        <asp:ListItem Value="f">Feminino</asp:ListItem>
                        <asp:ListItem Value="m">Masculino</asp:ListItem>
                        <asp:ListItem Selected="True">Selecione</asp:ListItem>
                    </asp:DropDownList>
                </div>
             </div>
             <div class="control-group">
                <label for="txtEmail2" class="control-label">&nbsp;Data Nascimento:</label>
                <div class="controls">
                  <asp:TextBox data-date-format="mm/dd/yy" placeholder="Data Nascimento" ID="txtNascimento" runat="server" class="input-medium"></asp:TextBox>
                </div>
             </div>
             <div class="control-group">
                <label for="txtEmail2" class="control-label">&nbsp; Senha:</label>
                <div class="controls">
                  <asp:TextBox data-date-format="mm/dd/yy" ID="txtPassword" runat="server" 
                        TextMode="Password" class="input-medium"></asp:TextBox>
                </div>
             </div>
             <div class="control-group">
                <label for="txtEmail2" class="control-label">&nbsp;Repita a Senha:</label>
                <div class="controls">
                  <asp:TextBox data-date-format="mm/dd/yy" ID="txtPassword2" runat="server" class="input-medium" 
                        TextMode="Password"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblSenha" runat="server" ForeColor="Red" Visible="False"></asp:Label>
                </div>
             </div>
                     <asp:Button ID="cadastro" runat="server" Text="Cadastrar" CssClass="btn btn-primary btn-large" onclick="Button1_Click" />
                 </div>
        </asp:View>
        <asp:View ID="View2" runat="server">
            <div class="well">
              <h2>Usuário salvo</h2>
            </div>
        </asp:View>
    </asp:MultiView>

</p>
<p>
</p>




</asp:Content>
