<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="myGoals.aspx.cs" Inherits="Chronos.myGoals" %>
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
<h1>Minhas Metas</h1>
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
                                            <br /><sup>Desde: Semana Passada </sup></sup>
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