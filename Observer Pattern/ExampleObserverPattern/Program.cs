using ExampleObserverPattern;

Console.WriteLine("Hello, World! Observer Pattern");
EstacaoMeriologica estacaoMeteorologica = new EstacaoMeriologica();
NovasAgenciasDeNoticias agenciasNoticias1 = new NovasAgenciasDeNoticias("Agencia de Noticia de São Paulo");
estacaoMeteorologica.Anexar(agenciasNoticias1);

NovasAgenciasDeNoticias agenciasNoticias2 = new NovasAgenciasDeNoticias("Agencia de Noticia de Suzano");
estacaoMeteorologica.Anexar(agenciasNoticias2);

estacaoMeteorologica.Temperatura = 31.4f;
estacaoMeteorologica.Temperatura = 25f;
estacaoMeteorologica.Temperatura = 26.7f;
estacaoMeteorologica.Temperatura = 34.7f;
estacaoMeteorologica.Temperatura = 22.7f;
estacaoMeteorologica.Temperatura = 15.7f;

Console.ReadLine();