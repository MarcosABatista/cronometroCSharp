Menu();

static void Menu()
{
  Console.Clear();
  Console.WriteLine("S = Segundo");
  Console.WriteLine("M = Minuto");
  Console.WriteLine("0 = Sair");
  Console.WriteLine("Quanto tempo deseja contar?");

  string data = Console.ReadLine().ToLower();
  char type = char.Parse(data.Substring(data.Length - 1, 1));
  int time = int.Parse(data.Substring(0, data.Length - 1));
  if (type != 's' & type != 'm')
  {
    Console.WriteLine("Opção invalida!");
  }
  else
  {
    int multiplicador = 1;
    if (type == 'm')
      multiplicador = 60;

    start(time * multiplicador);
  }
  Menu();
}
static void start(int time)
{
  int currentTime = 0;
  while (currentTime != time)
  {
    Console.Clear();
    currentTime++;
    Console.WriteLine(currentTime);
    Thread.Sleep(1000);

  }
  Console.Clear();
  System.Console.WriteLine("Cronometro finalizado!");
  Thread.Sleep(2000);
  Menu();

}