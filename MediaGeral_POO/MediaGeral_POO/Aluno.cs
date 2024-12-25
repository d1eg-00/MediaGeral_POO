using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaGeral_POO
{
    public class Aluno
    {
        public string Nome { get; private set; }
        private double[] _notas; // inicializando array com as notas
        public double Media
        {
            get
            {
                return CalcularMedia();
            }
        }

    public Aluno(string nome, int provas) //contrutor da classe
    {
        Nome = nome;
        _notas = new double[provas]; // array do tamanho da quantidade de provas

    }

    public void InserirNotas()
    {
        for (int i = 0; i < _notas.Length; i++) //preenche as notas de acordo com a quantidade de provas realizadas
        {
            Console.Write($"Nota # {i + 1} : ");
            _notas[i] = double.Parse(Console.ReadLine()!);
        }
    }

    private double CalcularMedia()
    {
        double total = 0;
        for (int i = 0; i < _notas.Length; i++)
        {
            total += _notas[i];
        }
        return total / _notas.Length;
    }

    }
}