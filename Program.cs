using System;
using System.Globalization;

public class Program{
    class Task{
        public string title;
        public DateTime expire;
        public int id;
        public bool completed;

        public Task(string titles, string date){
            title = titles;
            expire = DateTime.Parse(date, new CultureInfo("pt-BR"));
            id = count;
            completed = false;
            count++;
        }
    }
    static bool loop = true;
    static string line;
    static int count = 1;

    public static string spaces(int size, string original){
        size -= original.Length;
        string rtn = "";

        for(int i = 0; i < size; i++){
            rtn += " ";
        }

        return rtn;
    }

    static void Main(string[] args){
        List<Task> tasks = new List<Task>();
        Console.WriteLine("Bem vindo ao organizador de tarefas");
        Console.WriteLine("Lista de comandos: \n1- Adicionar tarefa \n2- Marcar tarefa como concluída \n3- Deletar tarefa concluída. \n4-Editar tarefa \n5- Sair.");
        while(loop){
            if(tasks.Count() == 0){Console.WriteLine("Você ainda não tem tarefas");}else{
                Console.WriteLine($"ID{spaces(4, "ID")}| Tarefa{spaces(30, "tarefa")}| Expira Em{spaces(20, " Expira Em")} | Status");
                tasks = tasks.OrderBy(o=>o.expire).ToList();
                foreach(Task item in tasks){
                    Console.WriteLine($"{item.id}{spaces(4, item.id.ToString())}| {item.title}{spaces(30, item.title)}| {item.expire} | {(item.completed ? "Finalizada" : "Não Finalizada")}");
                }
            }
            
            Console.WriteLine("Digite o comando desejado: ");
            line = Console.ReadLine();
            switch(line){
                case "1":
                    Console.WriteLine("Digite o título da tarefa: ");
                    string title = Console.ReadLine();
                    Console.WriteLine("Digite a data de expiração da tarefa (ex: '27 fev 2024'): ");
                    string expire = Console.ReadLine();
                    tasks.Add(new Task(title, expire));
                break;

                case "2":
                    Console.WriteLine("Digite o ID da tarefa que quer concluir");
                    tasks[tasks.FindIndex(item => item.id == Convert.ToInt32(Console.ReadLine()))].completed = true;
                break;

                case "3":
                    Console.WriteLine("Digite o Id da tarefa que quer Deletar");
                    line = Console.ReadLine();
                    if(!tasks[tasks.FindIndex(item => item.id == Convert.ToInt32(line))].completed){
                        Console.WriteLine("A tarefa precisa estar concluida para ser deletada");
                        break;
                    }
                    tasks.RemoveAt(tasks.FindIndex(item => item.id == Convert.ToInt32(line)));
                break;

                case "4":
                    Console.WriteLine("Digite o Id da tarefa que deseja editar");
                    int index = tasks.FindIndex(item => item.id == Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Digite o novo título da tarefa");
                    tasks[index].title = Console.ReadLine();
                    Console.WriteLine("Digite a nova data da tarefa");
                    tasks[index].expire = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));
                break;

                case "5":
                    loop = false;
                break;
            }
            
        }
    }
}