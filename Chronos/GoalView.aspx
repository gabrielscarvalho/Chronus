<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GoalView.aspx.cs" Inherits="Chronos.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

   <div class="well form-inline span8">
        <h2>Aprender a falar Alemão.</h2><br />
        <div class="span2">
          <img style="width:160px;height:120px" alt="" src="http://placehold.it/160x120">
        </div>
        <div class="span7"> 
             <span class="add-on"><i class="icon-user"></i> <b>2</b> seguidores </span>
            | <span class="add-on"><i class="icon-comment"></i> (<b>0</b>) novo(s) comentário(s) </span>
            | <span class="add-on" title="10 pessoas dizem que esse modo ajudou."><i class="icon-thumbs-up"></i> <b>10</b> pessoas.</span>
            | <span class="add-on" title="07 pessoas dizem que esse modo não ajudou."><i class="icon-thumbs-down"></i> <b>07</b> pessoas.</span>
            <br /><br />
            <h4>Descrição  <br /></h4>
            Aprender a falar alemão em um período de 2 anos.
        
        </div>
         <table class="table  table-striped">
                            <thead>
                                  <tr>
                                        <th>#</th>
                                        <th>Meta</th>
                                        <th>Data Prevista</th>
                                        <th>Quem fará ?</th>
                                  </tr>
                            </thead>
                            <tbody>
                                  <tr>
                                        <td><span class="add-on"><i class="icon-th"></i></span></td>
                                        <td>Inscrever em um curso de alemão.</td>
                                        <td>03/07/2012</td>
                                        <td>eu</td>
                                  </tr>
                                  <tr>
                                        <td><span class="add-on"><i class="icon-th"></i></span></td>
                                        <td>Iniciar a aula.</td>
                                        <td>03/07/2012</td>
                                        <td>eu</td>
                                  </tr>
                                   <tr>
                                        <td><span class="add-on"><i class="icon-th"></i></span></td>
                                        <td><asp:TextBox ID="txtMeta"  placeholder="Nova Meta" runat="server" class="input-xxlarge"></asp:TextBox></td>
                                        <td> <asp:TextBox data-date-format="mm/dd/yy" placeholder="Data Finalizar" ID="TextBox1" runat="server" class="input-small calendar"></asp:TextBox></td>
                                        <td>eu</td>
                                  </tr>
                            </tbody>
                  </table>
                  <asp:Button class="btn btn-large btn-success" ID="saveGoal" runat="server" Text="Salvar" />
                  <asp:Button class="btn btn-large btn-danger" ID="cancel" runat="server" Text="Cancelar" />
   </div>

</asp:Content>
