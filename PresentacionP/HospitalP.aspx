<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HospitalP.aspx.cs" Inherits="PresentacionP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>


    <style>
        * {
            padding: 0;
            margin: 0;
        }

        body {
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 50vh;
        }

        .principal {
            text-align: center;
            align-items: center;
        }

        .input-box {
            display: flex;
            justify-content: space-between;
        }

            .input-box label {
                margin: 0 150px;
            }

        h2 {
            text-align: center;
        }

        .buttons {
            display: flex;
            justify-content: space-between;
        }
    </style>

    <form id="form1" runat="server">

        <asp:Panel ID="pnlListadoProductos" runat="server" Width="100%">
            <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>
            <asp:Button ID="btnbuscar" runat="server" Text="Buscar Productos" OnClick="btnbuscar_Click" />
            <br />
            <br />
            <br />
            <asp:GridView ID="dtgListadoHospital" runat="server"
                AutoGenerateColumns="false" AutoGenerateSelectButton="true" OnSelectedIndexChanged="dtgListadoHospital_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Hospital_Cod" HeaderText="Id" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                    <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                    <asp:BoundField DataField="Num_cama" HeaderText="# Cama" />
                </Columns>

            </asp:GridView>

        </asp:Panel>

        <asp:Label ID="lblCorrecto" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        <br />
        <asp:Panel ID="pnlingresar" runat="server" Visible="TRUE">
            <h2 class="tittle">Hospitales</h2>
            <br />

            <div class="input-box" >
                <asp:Label ID="lblcod" runat="server" Text="Codigo Hospital: "></asp:Label>
                <asp:TextBox ID="txtcod" runat="server"></asp:TextBox>
            </div>

            <div class="input-box">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre Hospital: "></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </div>

            <div class="input-box">
                <asp:Label ID="lblDireccion" runat="server" Text="Direccion: "></asp:Label>
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            </div>

            <div class="input-box">
                <asp:Label ID="lblTelefono" runat="server" Text="Telefono: "></asp:Label>
                <asp:TextBox ID="txtTelefono" runat="server" Onkeypress="return isNumberKey(evt)"></asp:TextBox>
            </div>

            <div class="input-box">
                <asp:Label ID="lblNum_cama" runat="server" Text="Numero de camas: "></asp:Label>
                <asp:TextBox ID="txtNum_cama" runat="server"></asp:TextBox>
            </div>

            <br />

            <div class="buttons">
                <asp:Button ID="btnguardar" runat="server" Text="GUARDAR" OnClick="btnguardar_Click" />
            

                    <asp:Button ID="btnactualizar" runat="server" Text="Actualizar" OnClick="btnactualizar_Click" />

                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />

            </div>
        </asp:Panel>
    </form>
</body>
</html>
