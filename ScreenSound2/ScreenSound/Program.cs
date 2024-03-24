Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("João");

Episodio ep2 = new(2, "Técnicas de aprendizado", 57);
ep2.AdicionarConvidados("Rafael");
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Flávia");

Podcast podcast = new("Podcast Especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();