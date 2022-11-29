using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_da_velha
{
    class Jogo
    {
        char[,] matriz = new char[3, 3];
        List<char> valores = new List<char>();
        public bool Jogar(int linha, int coluna, int jogador)
        {
            bool retorno = false;
            if (jogador == 1)
            {
                if (matriz[linha, coluna] == 'O')
                {
                    retorno = true;
                }
                else
                {
                    matriz[linha, coluna] = 'X';
                    if (matriz.GetLength(1) == 3)
                    {
                        if (VerificaLinhas(matriz[linha, coluna]))
                        {
                            return true;
                        }
                        else if (VerificarColunas(matriz[linha, coluna]))
                        {
                            return true;
                        }
                        else if (VerificarDiagonais(matriz[linha, coluna]))
                        {
                            return true;
                        }
                    }
                }
            }
            else
            {
                if (matriz[linha, coluna] == 'X')
                {
                    retorno = true;
                }
                else
                {
                    matriz[linha, coluna] = 'O';
                    if (matriz.GetLength(1) == 3)
                    {
                        if (VerificaLinhas(matriz[linha, coluna]))
                        {
                            return true;
                        }
                        else if (VerificarColunas(matriz[linha, coluna]))
                        {
                            return true;
                        }
                        else if (VerificarDiagonais(matriz[linha, coluna]))
                        {
                            return true;
                        }
                    }
                }
            }
            valores.Add(matriz[linha, coluna]);
            return retorno;
        }
        public bool Empate()
        {
            
            if (valores.Count == 9)
            {
                return true;
            }
            return false;
        }
        public char QuemGanhou()
        {
            if (VerificaLinhas('X'))
            {
                return 'X';
            }
             if (VerificaLinhas('O'))
            {
                return 'O';
            }
             if (VerificarColunas('X'))
            {
                return 'X';
            }
             if (VerificarColunas('O'))
            {
                return 'O';
            }
             if(VerificarDiagonais('X'))
            {
                return 'X';
            }
             if (VerificarDiagonais('O'))
            {
                return 'O';
            }
            return 'N';
        }

        public bool VerificarDiagonais(char valor)
        {
            int qtd = 0;
            int c = 2;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        if (matriz[i, j] == valor)
                        {
                            qtd++;
                        }
                    }
                }
            }
            if (qtd == 3)
            {
                return true;
            }
            qtd = 0;
            for (int i = 0; i < 3; i++)
            {
                if (matriz[i, c] == valor)
                {
                    qtd++;
                }
                c--;
            }
            if (qtd == 3)
            {
                return true;
            }
            return false;
        }
        public bool VerificaLinhas(char valor)
        {
            int qtd = 0;
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            if (qtd > 0)
                            {
                                qtd = 0;
                            }
                        }
                        if (matriz[i, j] == valor)
                        {
                            qtd++;
                            if (qtd == 3)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            qtd = 0;
                        }
                    }
                    else if (i == 1)
                    {
                        if (j == 0)
                        {
                            if (qtd > 0)
                            {
                                qtd = 0;
                            }
                        }
                        if (matriz[i, j] == valor)
                        {
                            qtd++;
                            if (qtd == 3)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            qtd = 0;
                        }
                    }
                    else
                    {
                        if (j == 0)
                        {
                            if (qtd > 0)
                            {
                                qtd = 0;
                            }
                        }
                        if (matriz[i, j] == valor)
                        {
                            qtd++;
                            if (qtd == 3)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public bool VerificarColunas(char valor)
        {
            int qtd = 0;
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            if (qtd > 0)
                            {
                                qtd = 0;
                            }
                        }
                        if (matriz[j, i] == valor)
                        {
                            qtd++;
                            if (qtd == 3)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            qtd = 0;
                        }
                        
                    }
                    if (i == 1)
                    {
                        if (j == 0)
                        {
                            if (qtd > 0)
                            {
                                qtd = 0;
                            }
                        }
                        if (matriz[j, i] == valor)
                        {
                            qtd++;
                            if (qtd == 3)
                            {
                                return true;
                            }
                            if (j == 2 && matriz[j, i] == valor)
                            {
                                if (qtd == 3)
                                {
                                    return true;
                                }
                                else
                                {
                                    qtd = 0;
                                }
                            }
                        }
                        else
                        {
                            qtd = 0;
                        }

                    }
                    else if(i == 2)
                    {
                        if (j == 0)
                        {
                            if (qtd > 0)
                            {
                                qtd = 0;
                            }
                        }
                        if (matriz[j, i] == valor)
                        {
                            qtd++;
                            if (qtd == 3)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            qtd = 0;
                        }

                    }
                    
                }
            }
            return false;
        }
    }
}
