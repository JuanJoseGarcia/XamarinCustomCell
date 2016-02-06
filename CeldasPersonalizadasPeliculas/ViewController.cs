using System;

using UIKit;
using System.Drawing;
using System.Collections.Generic;

namespace CeldasPersonalizadasPeliculas
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.


			tvPeliculas.AutoresizingMask = UIViewAutoresizing.All;

			tvPeliculas.SeparatorColor = UIColor.Brown;
			tvPeliculas.SeparatorEffect = UIBlurEffect.FromStyle (UIBlurEffectStyle.Light);
			tvPeliculas.SeparatorInset.InsetRect (new RectangleF (10, 0, (float)tvPeliculas.Bounds.Width, 2));
			tvPeliculas.SeparatorStyle = UITableViewCellSeparatorStyle.DoubleLineEtched;

			List<Pelicula> peliculas = new List<Pelicula> ();


			peliculas.Add (new Pelicula (
				1,
				"Embarazados",
				"Juana Macías",
				5,
				"1h45m",
				"001.jpg",
				"La nueva película de Juana Macías está protagonizada por Paco León y Alexandra Jiménez que darán vida respectivamente a Fran y Alina. Fran y Alina son una pareja bien avenida que lleva casi toda su vida junta, tras varios años viviendo y disfrutando de su \"adolescencia eterna\". Alina, que ve que están más cerca de los 40 que los 30, toma la decisión de querer ser madre, sim embargo Fran no lo tiene tan claro. El siente que todavía es joven, y que existe la necesidad de cambiar su vida. Todo esto se complica cuando el ginecólogo les dice que Alina es premenopáusica, y que los espermatozoides de él son \"pocos, vagos, y anormales\". Esta comedia nos plantea aborda con sentido del humor las dificultades por las que pasan hoy en día muchas parejas."
			));
				
			peliculas.Add (new Pelicula (
				2,
				"Pesadillas",
				"Rob Letterman",
				7,
				"1h22m",
				"002.jpg",
				"Rob Letterman lleva a la gran pantalla la famosísima serie de novelas de terror para niños 'Pesadillas', escritas por R.L. Stine. Para la ocasión, han contado con Jack Black interpretando, precisamente, al autor de los libros, R.L. Stine. La historia se centra en Zach (Dylan Minnette), un joven que se traslada a una pequeña ciudad con su madre. Cuando está desempacando, conoce a su vecina, Hannah (Odeya Rush) y, por desgracia, también a su padre, un hombre misterioso que no quiere que su hija se relacione con los vecinos. Un día, investigando en casa de Hannah, encuentran una serie de libros bastante misteriosos, y cometen el error de abrirlos. Estos dejan escapar una serie de monstruos peligrosos y terroríficos que comienzan a hacer estragos por la ciudad. Zach, Hannah y un chico algo raro llamado Champ (Ryan Lee) se lanzarán a las calles para capturar a todos los monstruos y que vuelvan a las páginas de los libros de las que nunca deberían haber salido. 'Pesadillas' hace que cobren vida los monstruos más famosos de la saga, como la momia, el hombre lobo, los gnomos de jardín o la espeluznante marioneta Slappy."
			));

			peliculas.Add (new Pelicula (
				3,
				"Spotlight",
				"Tom McCarthy",
				8,
				"1h22m",
				"003.jpg",
				"'Spotlight' cuenta la verdadera historia de la investigación de los periodistas del Boston Globe que se alzó con el premio Pulitzer y que agitó la ciudad y causó una gran crisis en una de las instituciones más antiguas y de confianza. Cuando el equipo de reporteros del periódico indaga en las alegaciones acerca del abuso a niños perpetrado por miembros de la Iglesia Católica, su investigación desvela la tapadera de décadas en la cúpula del sistema religioso, legal y gubernamental de Boston, iniciando una corriente de revelaciones alrededor del mundo. Dirigida por el nominado al Oscar Tom McCarthy (co-guionista de 'Up'), 'Spotlight' es un tenso thriller de investigación, que plasma una de las historias de crímenes más importantes de la era moderna."
			));

			peliculas.Add (new Pelicula (
				4,
				"Star Wars: Episode VII - The Force Awakens",
				"J.J. Abrams",
				8,
				"1h22m",
				"004.jpg",
				"Primera entrega de la trilogía anunciada por The Walt Disney Company tras adquirir los derechos de la franquicia (propiedad de Lucasfilm Ltd. hasta 2012). George Lucas, creador de la saga, intervendrá tanto en este episodio como en los dos siguientes en calidad de consultor creativo. J.J. Abrams llevará la batuta en 'Star Wars: Episodio VII: El despertar de la fuerza'; además de dirigir la cinta, el creador de 'Lost' firma el libreto junto al veterano Lawrence Kasdan, una de las personas que más conoce el Universo y los personajes de la saga. En esta entrega se darán cita antiguos miembros del reparto original (Harrison Ford, Carrie Fisher o Mark Hamill) junto a nuevas promesas, como John Boyega o Daisy Ridley. 'Star Wars: El despertar de la fuerza' comienza aproximadamente 30 años después de los acontecimientos de 'Star Wars: El retorno del Jedi'. En esta ocasión conoceremos a tres nuevos protagonistas: una joven llamada Rey, un chico llamado Finn y un piloto de naves llamado Poe Dameron. Ellos tres formarán parte importante de un nuevo enfrentamiento entre el bien y el mal, encarnados por la Resistencia y la Primera Orden. 38 años después de la primera parte, llega un nuevo episodio de 'La Guerra de las Galaxias'. El lado oscuro regresa y lo hace con mayor fiereza que la última vez. El malvado Kylo Ren (Adam Driver) desea emular el poder de Darth Vader, provocando una hecatombe en la paz intergaláctica. Una nueva heroína surgirá del lado luminoso, Rey (Daisy Ridley). Le acompañará un Stormtrooper arrepentido, Finn (John Boyega), y un piloto rebelde Poe Dameron (Oscar Isaac). Juntos vencerán a un lado oscuro que regresa. Kylo Ren no viene solo, le acompañan la Capitán Phasma (Gwendoline Christie) y el General Hux (Domhnall Gleeson), que están a la orden del Líder Supremo Snoke (Andy Serkis), maestro de Kylo Ren y máxima figura del lado oscuro. Junto a los nuevos héroes, estarán el trío de personajes original para ayudarles en su nueva misión. Han Solo, la princesa Leia (convertida en general), Chewbacca y Luk Skywalker serán piezas clave para que Rey, Finn y Poe Dameron venzan al lado oscuro. "
			));

			peliculas.Add (new Pelicula (
				5,
				"Creed",
				"Ryan Coogler",
				5,
				"1h22m",
				"005.jpg",
				"Ryan Coogler se pone detrás de las cámaras para dirigir el que será el primer spin off de la famosa saga 'Rocky'. El emblemático personaje de Sylvester Stallone queda relegado a un segundo plano en 'Creed', film en el que todo el protagonismo recae sobre Michael B. Jordan, intérprete encargado de meterse en la piel de Adonis Creed, el hijo del archienemigo de Rocky Balboa (Sylvester Stallone), Apolo Creed. El joven boxeador, con habilidad y talento de sobra para la lucha, no tuvo ocasión de conocer a su padre, que murió antes de que este naciera, aún así no hay nadie que pueda negar que lleva el boxeo en la sangre, por lo que decide ir a Filadelfia en busca de Rocky para proponerle que sea su mentor. El veterano, a pesar de asegurar una y mil veces que ya no forma parte del mundo del boxeo, ve en Adonis la fuerza y determinación de su padre y decide entrenarle. Tessa Thompson (Bianca), Phylicia Rashad (Mary Anne Creed) y Tony Bellew ('Pretty' Ricky Conlan) completan el reparto de este film escrito también por Coogler."
			));

			peliculas.Add (new Pelicula (
				6,
				"La gran apuesta",
				"Adam McKay",
				7,
				"1h22m",
				"006.jpg",
				"'La gran apuesta' es la nueva película de Adam McKay, director de otras películas como 'Los otros dos', 'Hermanos por pelotas' o 'El reportero: La leyenda de Ron Burgundy'. La película es una adaptación de la novela de Michael Lewis, 'The Big Short: Inside the Doomsday Machine' y que cuenta con un reparto de lujo al estar protagonizada por Brad Pitt, Christian Bale, Finn Wittrock, Karen Gillan, Ryan Gosling, Marisa Tomei y Steve Carell, entre otros actores. Basada en hechos reales, el argumento de la película se centra en la crisis del sector inmobiliario que se produjo en Estados Unidos en otoño de 2008 y que desarrolló la posterior crisis económica que repercutió en el mundo entero. Cuatro individuos descubren que tanto los medios de comunicación, los bancos como el Gobierno se niegan a confirmar lo que es más que evidente, por lo que deciden apostar contra su propio país. Con ligeros toques de humor acido, esta película parte como una de las favoritas en los grandes premios de la industria cinematográfica."
			));

			peliculas.Add (new Pelicula (
				7,
				"El renacido",
				"Alejandro González Iñárritu",
				8,
				"1h22m",
				"007.jpg",
				"Basada en una historia real, 'El renacido (The Revenant)' sigue a Hugh Glass, un cazador de pieles que durante una expedición en 1822 fue abandonado a su suerte por sus compañeros después de ser atacado por un oso. Consigue sobrevivir milagrosamente y comienza un camino de cientos de kilómetros hasta la civilización, con el único objetivo de encontrar a los que le dieron por muerto y vengarse. Pero Glass se enfrentará también a otros problemas: deberá hacer frente a una región hostil, a una América salvaje dominada por la violencia, a un frío devastador así como a los continuos conflictos entre tribus de nativos americanos. Con la fuerza interior y la perseverancia como único apoyo, Glass realizará una búsqueda épica y brutal hasta alcanzar su propósito. Leonardo DiCaprio protagoniza 'The Revenant', película dirigida por Alejandro González Iñárritu, que cuenta con Tom Hardy como John Fitzgerald, Will Poulter como Jim Bridger y Domhnall Gleeson como Andrew Henry en el reparto. Guión de Mark L. Smith y el propio Alejandro González Iñárritu en base a la novela escrita por Michael Punke. La música del film corre a cargo de Carsten Nicolai y Ryûichi Sakamoto."
			));

			peliculas.Add (new Pelicula (
				8,
				"La quinta ola",
				"J Blakeson",
				5,
				"1h22m",
				"008.jpg",
				"Los alienígenas han atacado la Tierra en cuatro devastadoras oleadas que han diezmado a la población. La primera acabó con el suministro eléctrico. La segunda fue un gigantesco tsunami que subió el nivel del mar. La tercera, una peste que no dejó de extenderse. Mientras que la cuarta fue colonizando la mente de ciertos humanos para controlarlos. Pero todavía queda una oleada más. Cassie Sullivan (Chloë Grace Moretz), una joven de dieciséis años llena de miedo y desconfianza, quiere saber cuál es el próximo peligro para intentar proteger a su hermano pequeño (Zackary Arthur). Inmersa en una huída desesperada, un día conoce a Evan Walker (Alex Roe), un joven que podría ayudarla a descubrir los secretos de la Quinta Ola, si lograse confiar en él. J Blakeson vuelve a la dirección para encargarse de este proyecto escrito por Susannah Grant, Akiva Goldsman y Jeff Pinkner que se basa en la novela homónima de Rick Yancey, el primer libro de la trilogía aún incompleta."
			));

			peliculas.Add (new Pelicula (
				9,
				"Palmeras en la nieve",
				"Fernando González Molina",
				6,
				"1h22m",
				"009.jpg",
				"Adaptación del libro homónimo escrito por Luz Gabás en 2012. Un día, Clarence (Adriana Ugarte) descubre de forma accidental una carta olvidada, la cuál la lleva a viajar desde las montañas de Huesca a la isla de Fernando Poo (en la actualidad conocida como Bioko), que perteneció a la Guinea Española desde 1926 hasta 1968, cuando proclamó su independencia, y en la que su padre Jacobo (Alain Hernández) y su tío Kilian (Mario Casas) vivieron después de abandonar la nieve de la montaña oscense y donde les esperaba su padre, un veterano de la finca Sampaka, el lugar donde se cultiva y tuesta uno de los mejores cacaos del mundo. Allí la joven descubre un secreto sobre una historia de amor prohibido con relaciones en la historia y que llega hasta nuestros días. 'Palmeras en la nieve', rodada en el verano de 2014 en Gran Canaria, está dirigida por Fernando González Molina ('Fuga de cerebros 2', 'Tengo ganas de ti') y con un espectacular reparto formado por Mario Casas, Adriana Ugarte, Fernando Cayo, Macarena García, Daniel Grao, Mark Schardan, Berta Vázquez, Emilio Gutiérrez Caba, Celso Bugallo, Petra Martínez, Alain Hernández y José Manuel Poga."
			));

			peliculas.Add (new Pelicula (
				10,
				"La chica danesa",
				"Tom Hooper",
				7,
				"1h22m",
				"010.jpg",
				"'La chica danesa' narra la historia real del pintor danés, Einar Wegener, el primer hombre en operarse para cambiar de sexo, y su mujer Gerda, también pintora, que le apoyó y se mantuvo a su lado durante toda su vida tras la operación. El escenario escogido para retratar la historia es la ciudad de Copenhagen a principio de los años 20s. Un día, Gerda se dedica a pintar a su marido en un cuadro como si fuese una mujer y ahí es donde empieza todo. Una historia novedosa e inusual para la época en la que pasó. Einar Wegener, es interpretado por el oscarizado Eddie Redmayne, mientras que Alicia Vikander será la encargada de interpretar el papel de Gerda. Tom Hooper ('Los Miserables') es el director de la película."
			));

			peliculas.Add (new Pelicula (
				11,
				"Los odiosos ocho",
				"Quentin Tarantino",
				8,
				"1h22m",
				"011.jpg",
				"Quentin Tarantino nos traslada en su nueva película hasta Wyoming. En plena post-Guerra Civil Norteamericana encontramos una caravana llena de personajes dispares: un cazarrecompensas conocido como 'el verdugo' y su prisionera, un soldado negro de la Unión convertido en cazarrecompensas, y un sureño que dice ser el nuevo sheriff. El vehículo tiene que desviarse a causa de un gran temporal. Estos individuos permanecerán en un salón llamado La Mercería de Minnie, en medio de la nada, mientras esperan a que pase la tormenta de nieve. Allí se encontrarán con otros cuatro personajes: un verdugo de Red Rock, un vaquero, un general confederado y un hombre que se encarga del negocio de Minnie mientras ella está fuera. Con orígenes tan distintos, pronto surgirá la tensión entre ellos, y no quedará demasiado claro que todos vayan a salir de ese edificio cuando amaine la ventisca. El film, escrito y dirigido por el director de 'Malditos Bastardos', 'Kill Bill' y 'Pull Fiction', está protagonizado por Samuel L. Jackson, Channing Tatum, Kurt Russell y Jennifer Jason Leigh, entre otros."
			));

			peliculas.Add (new Pelicula (
				12,
				"Ocho apellidos catalanes",
				"Emilio Martínez Lázaro",
				6,
				"1h22m",
				"012.jpg",
				"Regresan a los cines Dani Rovira, Clara Lago, Karra Elejalde y Carmen Machi en la secuela de 'Ocho apellidos vascos', titulada 'Ocho apellidos catalanes'. En esta ocasión, de País Vasco y Andalucía saltamos a Cataluña, donde se ha ido Amaia (Clara Lago) por amor. Cuando se entera su padre, Koldo (Elejalde), sale corriendo a buscar a Rafa (Dani Rovira) para pedirle un amuleto familiar que necesita para su nuevo yerno. Pero, Rafa decidirá acompañarle para intentar impedir la boda de su amada vasca y \"rescatarla\" de las garras de un catalán (Berto Romero). Allí les esperan Pau, su abuela Roser (Rosa Maria Sardà) y Judit (Belén Cuesta), la wedding planner, que nos ofrecerán un nuevo choque cultural que acabó convirtiendo a 'Ocho apellidos vascos' en la película española más taquillera de la historia. 'Ocho apellidos catalanes' vuelve a contar con Emilio Martínez Lázaro en la dirección y con Borja Cobeaga y Diego San José firmando el guion, al igual que en la primera entrega. Alfonso Sánchez y Alberto López también regresan como Curro y Joaquín."
			));

			tvPeliculas.Source = new TableSourcePelicula (peliculas);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

