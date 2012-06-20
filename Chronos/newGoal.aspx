<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="newGoal.aspx.cs" Inherits="Chronos.newGoal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
        $(function () {
            $('#goalTabs a[href="#myGoals"]').tab('show')

            $('.calendar').datepicker({
                format: 'dd/mm/yyyy'
            });
        })
    
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h1>Nova Meta</h1>
<div class="tab-content">
        <div class="tab-pane active" id="newGoal">
            <div class="well form-inline auto">
                     <div class="control-group">
                        <label for="txtTitulo" class="control-label">&nbsp;Título:</label>
                        <div class="controls">
                              <asp:TextBox ID="txtTitulo"  placeholder="Título" runat="server" class="input-xxlarge"></asp:TextBox>
                        </div>
                     </div>
                     <div class="control-group">
                        <label for="txtDescricao" class="control-label">&nbsp;Descrição:</label>
                        <div class="controls">
                              <asp:TextBox ID="txtDescricao"  placeholder="Descrição" runat="server" TextMode="MultiLine" class="input-xxlarge"></asp:TextBox>
                        </div>
                     </div>
                      <div class="control-group">
                        <label for="txtInicio" class="control-label">&nbsp;Data Início:</label>
                        <div class="controls">
                             <asp:TextBox data-date-format="mm/dd/yy" placeholder="Data Início" ID="txtInicio" runat="server" class="input-medium calendar"></asp:TextBox>
                        </div>
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
                                        <td> <asp:TextBox data-date-format="mm/dd/yy" placeholder="Data Finalizar" 
                                                ID="txtDataPrevista" runat="server" class="input-small calendar"></asp:TextBox></td>
                                        <td>eu</td>
                                  </tr>
                            </tbody>
                  </table>
                 <asp:Button class="btn btn-large btn-success" ID="addGoal" runat="server" 
                         Text="Criar Meta" onclick="addGoal_Click" />
             </div>
</div>        
</asp:Content>