<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Goals.aspx.cs" Inherits="Chronos.WebForm4" %>
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
<h1>Objetivos</h1>


    <ul class="nav nav-tabs" id="goalTabs">
        <li><a href="#myGoals" data-toggle="tab" class="active" >Minhas Metas</a></li>
        <li><a href="#followingGoals" data-toggle="tab">Metas que sigo</a></li>
        <li><a href="#newGoal" data-toggle="tab">
        
        <span class="add-on"><i class="icon-plus-sign"></i></span> Nova Meta</a></li>
    </ul>

    <div class="tab-content">
        <div class="tab-pane active" id="myGoals">
         
          <table class="table  table-striped">
                            <thead>
                                  <tr>
                                        <th>Imagem</th>
                                        <th>Objetivo</th>
                                        <th>Data Prevista</th>
                                        <th>Status</th>
                                  </tr>
                            </thead>
                            <tbody>
                                  <tr>
                                        <td>
                                              <img alt="" src="http://placehold.it/160x120">
                                        </td>
                                        <td>
                                            Aprender alemão para viajar para a Alemanha.
                                        </td>
                                        <td>03/07/2012</td>
                                        <td>
                                            Em andamento
                                            <br /><span class="add-on"><i class="icon-user"></i> <b>6</b> seguidores </span>
                                            <br /><span class="add-on"><i class="icon-comment"></i> <u>(<b>3</b>) novos comentários</u> </span>
                                            
                                        </td>
                                  </tr>
                                  <tr>
                                        <td>
                                              <img alt="" src="http://placehold.it/160x120">
                                        </td>
                                        <td>Aprender a nadar.</td>
                                        <td>03/07/2012</td>
                                        <td>Parado
                                            <br /><sup>Desde: Semana Passada </sup>
                                            <br /><span class="add-on"><i class="icon-user"></i> <b>2</b> seguidores </span>
                                            <br /><span class="add-on"><i class="icon-comment"></i> (<b>0</b>) novo(s) comentário(s) </span>
                                        </td>
                                  </tr>
                                  <tr>
                                        <td>
                                              <img alt="" src="http://placehold.it/160x120">
                                        </td>
                                        <td>Aprender a tocar clarineta.</td>
                                        <td>03/07/2012</td>
                                        <td>Parado
                                            <br /><sup>Desde: Semana Passada </sup>
                                            <br /><span class="add-on"><i class="icon-user"></i> <b>21</b> seguidores </span>
                                            <br /><span class="add-on"><i class="icon-comment"></i> <u>(<b>8</b>) novo(s) comentário(s)</u> </span>
                                        </td>
                                  </tr>
                            </tbody>
                  </table>


        </div>
        <div class="tab-pane" id="followingGoals">
           <table class="table  table-striped">
                            <thead>
                                  <tr>
                                        <th>Imagem</th>
                                        <th>Objetivo</th>
                                        <th>Data Prevista</th>
                                        <th>Criador</th>
                                        <th>Status</th>
                                        
                                  </tr>
                            </thead>
                            <tbody>
                                  <tr>
                                        <td>
                                              <img alt="" src="http://placehold.it/160x120">
                                        </td>
                                        <td>
                                            Aprender uma lingua nova
                                        </td>
                                        <td>03/07/2010</td>
                                        <td><a href="">@UserX</a></td>
                                        <td>
                                            Finalizada
                                            <br /><span class="add-on"><i class="icon-user"></i> <b>6</b> seguidores </span>
                                            <br /><span class="add-on"><i class="icon-comment"></i> <u>(<b>3</b>) novos comentários</u> </span>
                                            <br /><span class="add-on" title="10 pessoas dizem que esse modo ajudou."><i class="icon-thumbs-up"></i> <b>10</b> pessoas.</span>
                                            <br /><span class="add-on" title="07 pessoas dizem que esse modo não ajudou."><i class="icon-thumbs-down"></i> <b>07</b> pessoas.</span>
                                        </td>
                                  </tr>
                                  <tr>
                                        <td>
                                              <img alt="" src="http://placehold.it/160x120">
                                        </td>
                                        <td>Aprender nado sincronizado</td>
                                        <td>03/07/2012</td>
                                                   <td><a href="">@UserXS</a></td>
                                        <td>Finalizado
                                            <br /><sup>Desde: Semana Passada </sup>
                                            <br /><span class="add-on"><i class="icon-user"></i> <b>2</b> seguidores </span>
                                            <br /><span class="add-on"><i class="icon-comment"></i> (<b>0</b>) novo(s) comentário(s) </span>
                                            <br /><span class="add-on" title="10 pessoas dizem que esse modo ajudou."><i class="icon-thumbs-up"></i> <b>10</b> pessoas.</span>
                                            <br /><span class="add-on" title="07 pessoas dizem que esse modo não ajudou."><i class="icon-thumbs-down"></i> <b>07</b> pessoas.</span>
                                        </td>
                                  </tr>
                                  <tr>
                                        <td>
                                              <img alt="" src="http://placehold.it/160x120">
                                        </td>
                                        <td>Aprender a tocar clarineta.</td>
                                        <td>03/07/2012</td>
                                                   <td><a href="">@UserXY</a></td>
                                        <td>Parado
                                            <br /><sup>Desde: Semana Passada </sup>
                                            <br /><span class="add-on"><i class="icon-user"></i> <b>21</b> seguidores </span>
                                            <br /><span class="add-on"><i class="icon-comment"></i> <u>(<b>8</b>) novo(s) comentário(s)</u> </span>
                                            
                                        </td>
                                  </tr>
                            </tbody>
                  </table>
        
        </div>
        <div class="tab-pane" id="newGoal">
            <div class="well form-inline span8">
                     <div class="control-group">
                        <label for="txtTitulo" class="control-label">&nbsp;Título:</label>
                        <div class="controls">
                              <asp:TextBox ID="txtTitulo"  placeholder="Título" runat="server" class="input-xxlarge"></asp:TextBox>
                        </div>
                     </div>
                     <div class="control-group">
                        <label for="txtDescricao" class="control-label">&nbsp;Descrição:</label>
                        <div class="controls">
                              <asp:TextBox ID="txtDescricao"  placeholder="Título" runat="server" TextMode="MultiLine" class="input-xxlarge"></asp:TextBox>
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
                                        <td> <asp:TextBox data-date-format="mm/dd/yy" placeholder="Data Finalizar" ID="TextBox1" runat="server" class="input-small calendar"></asp:TextBox></td>
                                        <td>eu</td>
                                  </tr>
                            </tbody>
                  </table>
                 <asp:Button class="btn btn-large btn-success" ID="addGoal" runat="server" Text="Criar Meta" />
             </div>
            
        
        </div>
    </div>
</asp:Content>
