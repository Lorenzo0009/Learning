/* Algoritmos são passos a serem seguidos por um 
módulo processador e seus respectivos usuários que, quando executados 
na ordem correta conseguem realizar determinada tarefa.

Identificadores (variavel)
1 Deve começar com uma letra
2 Os próximos podem ser letras ou números
3 Não pode utilizar nenhum símbolso, exceto [ _ ]
4 Não pode conter espaços em branco
5 Não pode conter letras com acentos
6 Não pode conter nenhuma palavra reserva (variável ou nome de métodos)

[Nota1] é uma varíavel ✅
[Média] não é uma varíavel ❌ (pois feri alguma das regras de criação de variáveis)
[9dade] ❌
[Algoritmo] ❌
[salário Bruto] ❌
[Inicio_Algoritmo] 

*/

using System;

class Algoritmos {
    static void main(string[] args) {

        /*
        var = criar uma variavel
        int = tipo de variável somente numero
        p1 = nome da variavel
        new Point(); = metodo para definir valor em c#

        Instâncias de classes são criadas usando o operador new, que aloca memória
        para uma nova instância, chama um construtor para inicializar a instância
        e retorna uma referência à instância. As instruções a seguir criam dois
        Point objetos e armazenam referências a esses objetos em duas variáveis:
        https://docs.microsoft.com/pt-br/dotnet/csha    rp/tour-of-csharp/types

        */
        var p1 = new Point(0, 0);
        var p2 = new Point(10, 20);

        /*
        A memória ocupada por um objeto é recuperada automaticamente quando 
        o objeto não está mais acessível. Não é necessário nem possível 
        desalocar explicitamente objetos em C#.
        */

    }
    
}