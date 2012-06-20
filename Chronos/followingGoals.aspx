<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="followingGoals.aspx.cs" Inherits="Chronos.followingGoals" %>
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
<h1>Metas que Sigo</h1>
<div class="tab-content">
        <div class="tab-pane active" id="followingGoals">
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
                                            <br /><sup>Desde: Semana Passada </sup></sup>
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
                                            <br /><sup>Desde: Semana Passada </sup></sup>
                                            <br /><span class="add-on"><i class="icon-user"></i> <b>21</b> seguidores </span>
                                            <br /><span class="add-on"><i class="icon-comment"></i> <u>(<b>8</b>) novo(s) comentário(s)</u> </span>
                                            
                                        </td>
                                  </tr>
                            </tbody>
                  </table>
        
        </div>
</div>        
</asp:Content>