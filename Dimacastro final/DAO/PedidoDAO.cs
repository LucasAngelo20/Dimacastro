using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Dimacastro_final
{
    public class PedidoDAO
    {
        public static List<PedidoDMO> selectPedidos(UserDMO user)
        {
            List<PedidoDMO> lsPedido = new List<PedidoDMO>();
            MySqlConnection con;
            MySqlDataReader dr;
            string conect = "server=localhost;user id=root;database=dimacastro";
            try
            {
                con = new MySqlConnection(conect);
                {
                    MySqlCommand command = new MySqlCommand("select_pedido", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@pId", user.id);
                    command.Connection.Open();
                    dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        PedidoDMO pedido = new PedidoDMO();
                        pedido.id = dr["id"].ToString();
                        pedido.fkLoja = dr["fkloja"].ToString();
                        pedido.valor = dr["valor"].ToString();
                        lsPedido.Add(pedido);
                    }
                }
                return lsPedido;
            }
            catch (Exception e)
            {
                user.ErrorMsg = e.Message;
                return lsPedido;
            }
        }
        public static bool insertPedido(PedidoDMO pedido)
        {
            MySqlConnection con;
            MySqlDataReader dr;
            string conect = "server=localhost;user id=root;database=dimacastro";
            try
            {
                con = new MySqlConnection(conect);
                {
                    MySqlCommand command = new MySqlCommand("insert_pedido", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@pFkuser", pedido.fkUser);
                    command.Parameters.AddWithValue("@pValor", pedido.valor);
                    command.Parameters.AddWithValue("@pFkloja", pedido.fkLoja);
                    command.Connection.Open();
                    dr = command.ExecuteReader();

                }
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }

        public static List<PedidoDMO> selectPedidosAdm()
        {
            List<PedidoDMO> lsPedido = new List<PedidoDMO>();
            MySqlConnection con;
            MySqlDataReader dr;
            string conect = "server=localhost;user id=root;database=dimacastro";
            try
            {
                con = new MySqlConnection(conect);
                {
                    MySqlCommand command = new MySqlCommand("select_pedido_adm", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection.Open();
                    dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        PedidoDMO pedido = new PedidoDMO();
                        pedido.id = dr["id"].ToString();
                        pedido.fkLoja = dr["fkloja"].ToString();
                        pedido.valor = dr["valor"].ToString();
                        pedido.fkUser = dr["fkUser"].ToString();
                        lsPedido.Add(pedido);
                    }
                }
                return lsPedido;
            }
            catch (Exception e)
            {
                return lsPedido;
            }
        }

    }
}