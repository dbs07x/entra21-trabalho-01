using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao02
{
    // Aluno: Gustavo Lemos
    public class Calendario
    {
        public DateTime Data;

        public string ObterDiaPorExtenso()
        {
            string numeroPorExtenso = "";
            if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "0")
            {
                numeroPorExtenso = "Um";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "2" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "0")
            {
                numeroPorExtenso = "Dois";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "3" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "0")
            {
                numeroPorExtenso = "Três";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "4" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "0")
            {
                numeroPorExtenso = "Quatro";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "5" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "0")
            {
                numeroPorExtenso = "Cinco";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "6" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "0")
            {
                numeroPorExtenso = "Seis";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "7" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "0")
            {
                numeroPorExtenso = "Sete";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "8" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "0")
            {
                numeroPorExtenso = "Oito";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "9" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "0")
            {
                numeroPorExtenso = "Nove";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "0" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "1")
            {
                numeroPorExtenso = "Dez";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "1")
            {
                numeroPorExtenso = "Onze";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "2" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "1")
            {
                numeroPorExtenso = "Doze";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "3" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "1")
            {
                numeroPorExtenso = "Treze";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "4" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "1")
            {
                numeroPorExtenso = "Quatorze";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "5" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "1")
            {
                numeroPorExtenso = "Quinze";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "6" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "1")
            {
                numeroPorExtenso = "Dezesseis";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "7" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "1")
            {
                numeroPorExtenso = "Dezessete";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "8" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "1")
            {
                numeroPorExtenso = "Dezoito";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "9" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "1")
            {
                numeroPorExtenso = "Dezenove";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "0" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "2")
            {
                numeroPorExtenso = "Vinte";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "2")
            {
                numeroPorExtenso = "Vinte e um";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "2" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "2")
            {
                numeroPorExtenso = "Vinte e dois";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "3" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "2")
            {
                numeroPorExtenso = "Vinte e três";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "4" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "2")
            {
                numeroPorExtenso = "Vinte e quatro";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "5" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "2")
            {
                numeroPorExtenso = "Vinte e cinco";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "6" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "2")
            {
                numeroPorExtenso = "Vinte e seis";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "7" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "2")
            {
                numeroPorExtenso = "Vinte e sete";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "8" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "2")
            {
                numeroPorExtenso = "Vinte e oito";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "9" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "2")
            {
                numeroPorExtenso = "Vinte e nove";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "0" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "3")
            {
                numeroPorExtenso = "Trinta";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(1, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(0, 1) == "3")
            {
                numeroPorExtenso = "Trinta e um";
            }

            return numeroPorExtenso;
        }

        public string ObterMesPorExtenso()
        {
            string numeroPorExtenso = "";
            if (Data.ToString("dd/MM/yyyy").Substring(4, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(3, 1) == "0")
            {
                numeroPorExtenso = "janeiro";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(4, 1) == "2" && Data.ToString("dd/MM/yyyy").Substring(3, 1) == "0")
            {
                numeroPorExtenso = "fevereiro";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(4, 1) == "3" && Data.ToString("dd/MM/yyyy").Substring(3, 1) == "0")
            {
                numeroPorExtenso = "março";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(4, 1) == "4" && Data.ToString("dd/MM/yyyy").Substring(3, 1) == "0")
            {
                numeroPorExtenso = "abril";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(4, 1) == "5" && Data.ToString("dd/MM/yyyy").Substring(3, 1) == "0")
            {
                numeroPorExtenso = "maio";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(4, 1) == "6" && Data.ToString("dd/MM/yyyy").Substring(3, 1) == "0")
            {
                numeroPorExtenso = "junho";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(4, 1) == "7" && Data.ToString("dd/MM/yyyy").Substring(3, 1) == "0")
            {
                numeroPorExtenso = "julho";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(4, 1) == "8" && Data.ToString("dd/MM/yyyy").Substring(3, 1) == "0")
            {
                numeroPorExtenso = "agosto";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(4, 1) == "9" && Data.ToString("dd/MM/yyyy").Substring(3, 1) == "0")
            {
                numeroPorExtenso = "setembro";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(4, 1) == "0" && Data.ToString("dd/MM/yyyy").Substring(3, 1) == "1")
            {
                numeroPorExtenso = "outubro";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(4, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(3, 1) == "1")
            {
                numeroPorExtenso = "novembro";
            }
            else
            {
                numeroPorExtenso = "dezembro";
            }

            return numeroPorExtenso;
        }

        public string ObterAnoPorExtenso()
        {
            string milharPorExtenso = "";
            if (Data.ToString("dd/MM/yyyy").Substring(6, 1) == "1")
            {
                milharPorExtenso = "mil";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) == "2")
            {
                milharPorExtenso = "dois mil";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) == "3")
            {
                milharPorExtenso = "três mil";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) == "4")
            {
                milharPorExtenso = "quatro mil";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) == "5")
            {
                milharPorExtenso = "cinco mil";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) == "6")
            {
                milharPorExtenso = "seis mil";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) == "7")
            {
                milharPorExtenso = "sete mil";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) == "8")
            {
                milharPorExtenso = "oito mil";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) == "9")
            {
                milharPorExtenso = "nove mil";
            }
            else { }

            string centenaPorExtenso = "";
            if (Data.ToString("dd/MM/yyyy").Substring(7, 1) == "1")
            {
                centenaPorExtenso = "cento";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(7, 1) == "2")
            {
                centenaPorExtenso = "duzentos";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(7, 1) == "3")
            {
                centenaPorExtenso = "trezentos";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(7, 1) == "4")
            {
                centenaPorExtenso = "quatrocentos";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(7, 1) == "5")
            {
                centenaPorExtenso = "quinhentos";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(7, 1) == "6")
            {
                centenaPorExtenso = "seiscentos";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(7, 1) == "7")
            {
                centenaPorExtenso = "setecentos";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(7, 1) == "8")
            {
                centenaPorExtenso = "oitocentos";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(7, 1) == "9")
            {
                centenaPorExtenso = "novecentos";
            }
            else { }

            string dezenaPorExtenso = "";
            if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(9, 1) == "0")
            {
                dezenaPorExtenso = "dez";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(9, 1) == "1")
            {
                dezenaPorExtenso = "onze";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(9, 1) == "2")
            {
                dezenaPorExtenso = "doze";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(9, 1) == "3")
            {
                dezenaPorExtenso = "treze";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(9, 1) == "4")
            {
                dezenaPorExtenso = "quatorze";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(9, 1) == "5")
            {
                dezenaPorExtenso = "quinze";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(9, 1) == "6")
            {
                dezenaPorExtenso = "dezesseis";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(9, 1) == "7")
            {
                dezenaPorExtenso = "dezessete";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(9, 1) == "8")
            {
                dezenaPorExtenso = "dezoito";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(9, 1) == "9")
            {
                dezenaPorExtenso = "dezenove";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "2")
            {
                dezenaPorExtenso = "vinte";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "3")
            {
                dezenaPorExtenso = "trinta";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "4")
            {
                dezenaPorExtenso = "quarenta";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "5")
            {
                dezenaPorExtenso = "cinquenta";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "6")
            {
                dezenaPorExtenso = "sessenta";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "7")
            {
                dezenaPorExtenso = "setenta";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "8")
            {
                dezenaPorExtenso = "oitenta";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "9")
            {
                dezenaPorExtenso = "noventa";
            }
            else
            {
                dezenaPorExtenso = "zero";
            }

            string unidadePorExtenso = "";
            if (Data.ToString("dd/MM/yyyy").Substring(9, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(8, 1) != "1")
            {
                unidadePorExtenso = "um";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(9, 1) == "2" && Data.ToString("dd/MM/yyyy").Substring(8, 1) != "1")
            {
                unidadePorExtenso = "dois";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(9, 1) == "3" && Data.ToString("dd/MM/yyyy").Substring(8, 1) != "1")
            {
                unidadePorExtenso = "três";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(9, 1) == "4" && Data.ToString("dd/MM/yyyy").Substring(8, 1) != "1")
            {
                unidadePorExtenso = "quatro";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(9, 1) == "5" && Data.ToString("dd/MM/yyyy").Substring(8, 1) != "1")
            {
                unidadePorExtenso = "cinco";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(9, 1) == "6" && Data.ToString("dd/MM/yyyy").Substring(8, 1) != "1")
            {
                unidadePorExtenso = "seis";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(9, 1) == "7" && Data.ToString("dd/MM/yyyy").Substring(8, 1) != "1")
            {
                unidadePorExtenso = "sete";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(9, 1) == "8" && Data.ToString("dd/MM/yyyy").Substring(8, 1) != "1")
            {
                unidadePorExtenso = "oito";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(9, 1) == "9" && Data.ToString("dd/MM/yyyy").Substring(8, 1) != "1")
            {
                unidadePorExtenso = "nove";
            }
            else
            {

            }

            string anoPorExtenso = "";
            if (Data.ToString("dd/MM/yyyy").Substring(6, 1) == "0" && Data.ToString("dd/MM/yyyy").Substring(7, 1) == "0"
                && Data.ToString("dd/MM/yyyy").Substring(8, 1) == "0" && Data.ToString("dd/MM/yyyy").Substring(9, 1) == "0")
            {
                anoPorExtenso = "zero";
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) == "0" && Data.ToString("dd/MM/yyyy").Substring(7, 1) == "0"
                && Data.ToString("dd/MM/yyyy").Substring(8, 1) == "0" && Data.ToString("dd/MM/yyyy").Substring(9, 1) != "0")
            {
                anoPorExtenso = unidadePorExtenso;
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) == "0" && Data.ToString("dd/MM/yyyy").Substring(7, 1) == "0"
                && Data.ToString("dd/MM/yyyy").Substring(8, 1) != "0" && Data.ToString("dd/MM/yyyy").Substring(9, 1) != "0")
            {
                if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(9, 1) != "0")
                {
                    anoPorExtenso = dezenaPorExtenso;
                }
                else
                {
                    anoPorExtenso = dezenaPorExtenso + " e " + unidadePorExtenso;
                }
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) == "0" && Data.ToString("dd/MM/yyyy").Substring(7, 1) != "0"
                && Data.ToString("dd/MM/yyyy").Substring(8, 1) != "0" && Data.ToString("dd/MM/yyyy").Substring(9, 1) != "0")
            {
                if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(9, 1) != "0")
                {
                    anoPorExtenso = centenaPorExtenso + " e " + dezenaPorExtenso;
                }
                else
                {
                    anoPorExtenso = centenaPorExtenso + " e " + dezenaPorExtenso + " e " + unidadePorExtenso;
                }
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) != "0" && Data.ToString("dd/MM/yyyy").Substring(7, 1) != "0"
                && Data.ToString("dd/MM/yyyy").Substring(8, 1) != "0" && Data.ToString("dd/MM/yyyy").Substring(9, 1) != "0")
            {
                if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(9, 1) != "0")
                {
                    anoPorExtenso = milharPorExtenso + " e " + centenaPorExtenso + " e " + dezenaPorExtenso;
                }
                else
                {
                    anoPorExtenso = milharPorExtenso + " e " + centenaPorExtenso + " e " + dezenaPorExtenso + " e " + unidadePorExtenso;
                }
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) != "0" && Data.ToString("dd/MM/yyyy").Substring(7, 1) != "0"
                && Data.ToString("dd/MM/yyyy").Substring(8, 1) != "0" && Data.ToString("dd/MM/yyyy").Substring(9, 1) == "0")
            {
                anoPorExtenso = milharPorExtenso + " e " + centenaPorExtenso + " e " + dezenaPorExtenso;
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) != "0" && Data.ToString("dd/MM/yyyy").Substring(7, 1) != "0"
                && Data.ToString("dd/MM/yyyy").Substring(8, 1) == "0" && Data.ToString("dd/MM/yyyy").Substring(9, 1) == "0")
            {
                anoPorExtenso = milharPorExtenso + " e " + centenaPorExtenso;
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) != "0" && Data.ToString("dd/MM/yyyy").Substring(7, 1) == "0"
                && Data.ToString("dd/MM/yyyy").Substring(8, 1) == "0" && Data.ToString("dd/MM/yyyy").Substring(9, 1) == "0")
            {
                anoPorExtenso = milharPorExtenso;
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) != "0" && Data.ToString("dd/MM/yyyy").Substring(7, 1) != "0"
               && Data.ToString("dd/MM/yyyy").Substring(8, 1) == "0" && Data.ToString("dd/MM/yyyy").Substring(9, 1) != "0")
            {
                anoPorExtenso = milharPorExtenso + " e " + centenaPorExtenso + " e " + unidadePorExtenso;
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) != "0" && Data.ToString("dd/MM/yyyy").Substring(7, 1) == "0"
               && Data.ToString("dd/MM/yyyy").Substring(8, 1) != "0" && Data.ToString("dd/MM/yyyy").Substring(9, 1) != "0")
            {
                if (Data.ToString("dd/MM/yyyy").Substring(8, 1) == "1" && Data.ToString("dd/MM/yyyy").Substring(9, 1) != "0")
                {
                    anoPorExtenso = milharPorExtenso + " e " + dezenaPorExtenso;
                }
                else
                {
                    anoPorExtenso = milharPorExtenso + " e " + dezenaPorExtenso + " e " + unidadePorExtenso;
                }
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) != "0" && Data.ToString("dd/MM/yyyy").Substring(7, 1) == "0"
               && Data.ToString("dd/MM/yyyy").Substring(8, 1) == "0" && Data.ToString("dd/MM/yyyy").Substring(9, 1) != "0")
            {
                anoPorExtenso = milharPorExtenso + " e " + unidadePorExtenso;
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) != "0" && Data.ToString("dd/MM/yyyy").Substring(7, 1) == "0"
               && Data.ToString("dd/MM/yyyy").Substring(8, 1) != "0" && Data.ToString("dd/MM/yyyy").Substring(9, 1) == "0")
            {
                anoPorExtenso = milharPorExtenso + " e " + dezenaPorExtenso;
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) == "0" && Data.ToString("dd/MM/yyyy").Substring(7, 1) == "0"
              && Data.ToString("dd/MM/yyyy").Substring(8, 1) != "0" && Data.ToString("dd/MM/yyyy").Substring(9, 1) == "0")
            {
                anoPorExtenso = dezenaPorExtenso;
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) == "0" && Data.ToString("dd/MM/yyyy").Substring(7, 1) != "0"
              && Data.ToString("dd/MM/yyyy").Substring(8, 1) == "0" && Data.ToString("dd/MM/yyyy").Substring(9, 1) == "0")
            {
                anoPorExtenso = centenaPorExtenso;
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) == "0" && Data.ToString("dd/MM/yyyy").Substring(7, 1) != "0"
              && Data.ToString("dd/MM/yyyy").Substring(8, 1) != "0" && Data.ToString("dd/MM/yyyy").Substring(9, 1) == "0")
            {
                anoPorExtenso = centenaPorExtenso + " e " + dezenaPorExtenso;
            }
            else if (Data.ToString("dd/MM/yyyy").Substring(6, 1) == "0" && Data.ToString("dd/MM/yyyy").Substring(7, 1) != "0"
              && Data.ToString("dd/MM/yyyy").Substring(8, 1) == "0" && Data.ToString("dd/MM/yyyy").Substring(9, 1) != "0")
            {
                anoPorExtenso = centenaPorExtenso + " e " + unidadePorExtenso;
            }

            return anoPorExtenso;
        }

        public string ObterDataCompletaPorExtenso()
        {
            var dataCompletaPorExtenso = ObterDiaPorExtenso() + " de " + ObterMesPorExtenso().ToLower() + " de " + ObterAnoPorExtenso().ToLower();
            
            return dataCompletaPorExtenso;
        }

    }
}
