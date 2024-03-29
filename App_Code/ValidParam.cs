﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class ValidParam
{
    public ValidParam()
    {
    }

    public static string ValidarParametro(string Parametro)
    {
        return  Parametro.Replace("'", "''");;
    }

    public static string ValidarEditor(String Parametro)
    { 
        string s;
        Parametro = Parametro.ToString().Trim();
        Parametro = Parametro.Replace(" or ", "");
        Parametro = Parametro.Replace(" and ", "");
        Parametro = Parametro.Replace("update", "");
        Parametro = Parametro.Replace("-shutdown", "");
        Parametro = Parametro.Replace("¨", "");
        Parametro = Parametro.Replace("'or'1'='1'", "");
        Parametro = Parametro.Replace("--", "");
        Parametro = Parametro.Replace("insert", "");
        Parametro = Parametro.Replace("drop", "");
        Parametro = Parametro.Replace("delet", "");
        Parametro = Parametro.Replace("xp_", "");
        Parametro = Parametro.Replace("select", "");
        Parametro = Parametro.Replace("&nbsp;", " ");        
        s = Parametro;
        return s; 
    }

    public static bool ValidarTamanho(string Parametro, int Tamanho)
    { 
        bool retorno;

        if (Parametro.Length <= Tamanho) { retorno = true; } else { retorno = false; };

        return retorno;
    }
    public static bool ValidarInteiroPositivo(string Parametro)
    {
        bool retorno;
        retorno = false;

        try
        {
            Int64.Parse(Parametro);
            retorno = true;
        }
        catch (Exception e)
        {
            retorno = false;
            
        }

        if (retorno != false)
        {
            if (Convert.ToInt64(Parametro) >= 0) { retorno = true; } else { retorno = false; };
        }

        return retorno;
    }
    
    //Este método converte o parametro string em bollean, para utilizar em conjunto com o componente checkbox.
    public static bool CheckToBool(string Parametro)
    {

        bool retorno;

        if (Parametro == "S") { retorno = true; } else { retorno = false; };

        return retorno;
    }

    //Este método converte o parametro bollean em string, para utilizar em conjunto com o componente checkbox.
    public static string BoolToCheck(bool Parametro)
    {

        string retorno;

        if (Parametro == true) { retorno = "S"; } else { retorno = "N"; };

        return retorno;
    }

    //Método que valida o CPF
    public static bool ValidaCPF(string vrCPF)
    {
        string valor = vrCPF.Replace(".", "");
        valor = valor.Replace("-", "");

        if (valor.Length != 11)
            return false;

        bool igual = true;
        for (int i = 1; i < 11 && igual; i++)
            if (valor[i] != valor[0])
                igual = false;

        if (igual || valor == "12345678909")
            return false;

        int[] numeros = new int[11];
        for (int i = 0; i < 11; i++)
            numeros[i] = int.Parse(
            valor[i].ToString());

        int soma = 0;
        for (int i = 0; i < 9; i++)
            soma += (10 - i) * numeros[i];

        int resultado = soma % 11;
        if (resultado == 1 || resultado == 0)
        {
            if (numeros[9] != 0)
                return false;
        }
        else if (numeros[9] != 11 - resultado)
            return false;

        soma = 0;
        for (int i = 0; i < 10; i++)
            soma += (11 - i) * numeros[i];

        resultado = soma % 11;

        if (resultado == 1 || resultado == 0)
        {
            if (numeros[10] != 0)
                return false;

        }
        else
            if (numeros[10] != 11 - resultado)
                return false;
        return true;

    }

    //Método que valida o CNPJ 
    public static bool ValidaCNPJ(string vrCNPJ)
    {

        string CNPJ = vrCNPJ.Replace(".", "");
        CNPJ = CNPJ.Replace("/", "");
        CNPJ = CNPJ.Replace("-", "");

        int[] digitos, soma, resultado;
        int nrDig;
        string ftmt;
        bool[] CNPJOk;

        ftmt = "6543298765432";
        digitos = new int[14];
        soma = new int[2];
        soma[0] = 0;
        soma[1] = 0;
        resultado = new int[2];
        resultado[0] = 0;
        resultado[1] = 0;
        CNPJOk = new bool[2];
        CNPJOk[0] = false;
        CNPJOk[1] = false;

        try
        {
            for (nrDig = 0; nrDig < 14; nrDig++)
            {
                digitos[nrDig] = int.Parse(
                 CNPJ.Substring(nrDig, 1));
                if (nrDig <= 11)
                    soma[0] += (digitos[nrDig] *
                    int.Parse(ftmt.Substring(
                      nrDig + 1, 1)));
                if (nrDig <= 12)
                    soma[1] += (digitos[nrDig] *
                    int.Parse(ftmt.Substring(
                      nrDig, 1)));
            }

            for (nrDig = 0; nrDig < 2; nrDig++)
            {
                resultado[nrDig] = (soma[nrDig] % 11);
                if ((resultado[nrDig] == 0) || (resultado[nrDig] == 1))
                    CNPJOk[nrDig] = (
                    digitos[12 + nrDig] == 0);

                else
                    CNPJOk[nrDig] = (
                    digitos[12 + nrDig] == (
                    11 - resultado[nrDig]));

            }

            return (CNPJOk[0] && CNPJOk[1]);

        }
        catch
        {
            return false;
        }

    }

    //Método que valida o Cep
    public static bool ValidaCep(string cep)
    {
        if (cep.Length == 8)
        {
            cep = cep.Substring(0, 5) + "-" + cep.Substring(5, 3);
            //txt.Text = cep;
        }
        return System.Text.RegularExpressions.Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}"));
    }

    //Método que valida o Email
    public static bool ValidaEmail(string email)
    {
        return System.Text.RegularExpressions.Regex.IsMatch(email, ("(?<user>[^@]+)@(?<host>.+)"));
    }

}

