using ATV_3bi.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATV_3bi.Repositório
{
    public class Action
    {
        Connection con = new Connection();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastrarFuncionario(Funcionario funcionario)
        {
            string data_sistema = Convert.ToDateTime(funcionario.FuncDtNasc).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into tbFuncionario values(@FuncCod,@FuncNome,@FuncCpf,@FuncRg,@FuncDtNasc,@FuncEnd,@FuncCel,@FuncEmail,@FuncCargo)", con.ConectarBD());
            cmd.Parameters.Add("FuncCod", MySqlDbType.Int32).Value = funcionario.FuncCod;
            cmd.Parameters.Add("FuncNome", MySqlDbType.VarChar).Value = funcionario.FuncNome;
            cmd.Parameters.Add("FuncCpf", MySqlDbType.VarChar).Value = funcionario.FuncCpf;
            cmd.Parameters.Add("FuncRg", MySqlDbType.VarChar).Value = funcionario.FuncRg;
            cmd.Parameters.Add("FuncDtNasc", MySqlDbType.Date).Value = data_sistema;
            cmd.Parameters.Add("FuncEnd", MySqlDbType.VarChar).Value = funcionario.FuncEnd;
            cmd.Parameters.Add("FuncCel", MySqlDbType.Double).Value = funcionario.FuncCel;
            cmd.Parameters.Add("FuncEmail", MySqlDbType.VarChar).Value = funcionario.FuncEmail;
            cmd.Parameters.Add("FuncCargo", MySqlDbType.VarChar).Value = funcionario.FuncCargo;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public void CadastrarCliente(Cliente cliente)
        {
            string data_sistema = Convert.ToDateTime(cliente.CliDtNasc).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into tbCliente values(@CliNome,@CliCpf,CliDtNasc,@CliEmail,@CliCel,@CliEnd)", con.ConectarBD());
            cmd.Parameters.Add("CliNome", MySqlDbType.VarChar).Value = cliente.CliNome;
            cmd.Parameters.Add("CliCpf", MySqlDbType.VarChar).Value = cliente.CliCpf;
            cmd.Parameters.Add("CliDtNasc", MySqlDbType.Date).Value = data_sistema;
            cmd.Parameters.Add("CliEmail", MySqlDbType.VarChar).Value = cliente.CliEmail;
            cmd.Parameters.Add("CliCel", MySqlDbType.Double).Value = cliente.CliCel;
            cmd.Parameters.Add("CliEnd", MySqlDbType.VarChar).Value = cliente.CliEnd;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public void CadastrarJogo(Jogo jogo)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbJogo values(@JogoCod,@JogoNome,@JogoVersao,@JogoDev,@JogoGen,@JogoFxEt,@JogoPlat,@JogoAnoLanc,@JogoSin)", con.ConectarBD());
            cmd.Parameters.Add("JogoCod", MySqlDbType.Int32).Value = jogo.JogoCod;
            cmd.Parameters.Add("JogoNome", MySqlDbType.VarChar).Value = jogo.JogoNome;
            cmd.Parameters.Add("JogoVersao", MySqlDbType.VarChar).Value = jogo.JogoVersao;
            cmd.Parameters.Add("JogoDev", MySqlDbType.VarChar).Value = jogo.JogoDev;
            cmd.Parameters.Add("JogoGen", MySqlDbType.VarChar).Value = jogo.JogoGen;
            cmd.Parameters.Add("JogoFxEt", MySqlDbType.VarChar).Value = jogo.JogoFxEt;
            cmd.Parameters.Add("JogoPlat", MySqlDbType.VarChar).Value = jogo.JogoPlat;
            cmd.Parameters.Add("JogoAnoLanc", MySqlDbType.VarChar).Value = jogo.JogoAnoLanc;
            cmd.Parameters.Add("JogoSin", MySqlDbType.VarChar).Value = jogo.JogoSin;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }
    }
}