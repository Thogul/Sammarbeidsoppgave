# Sammarbeidsoppgave

Alle metoder skal kunne være så modulære som mulig. Det vil si at det skal brukes argumenter når man kaller metoden.
I hovedmenyen må det være en dør som skal hete pctbxDoor1 med korresponderende label som passer: lblDoor1. Dette gjøres for alle dørene i menyen. Det skal være en begynn dør, en exit dør og en settingsdør.
Når man er i spill: da skal det finnes 5 bilder å velge mellom på skjermen. De skal hete bilde1, bilde 2 og videre. Området man legger svarene sine i skal hete answer1 og answer2. Svaret skal hete result.
Metoder:
1.	Bevegelse og interaksjoner i meny. Denne metoden skal utføre bevegelsene til karakteren du styrer mens du er i menyen. Trenger flere elementer:
a.	Sjekke om du har beveget deg
b.	Sjekke om du får lov til å flytte deg
i.	Om man er utenfor menyen
ii.	Å sjekke om man kommer til å krasje med noe
2.	Finne fram et spørsmål og bilder som hører til spørsmålet	
a.	Henter det ut fra klassen som inneholder bildene og spørsmålene
3.	Drag and drop metoder for å sjekke om objektet er blir sluppet ned på riktig plass og om ikke sette den tilbake til der den kom fra
4.	Metode for å legge ut alle bildene og sette opp spørsmålet. Kanskje pushe alle bildene inn i en list og legge alle elementene ut på spill-området
5.	En initialiseringsmetode som plasserer ut alle elementene til hovedmenyen.



Klasser:
1.	En klasse som det skal lages en instanse av når spille starter. Den skal brukes til å holde på alle spørsmålene og bildene som skal brukes til hvert enkelt spørsmål
2.	Spill informasjonsklasse. Denne klassen skal passe på all spillinformasjonen. Alle verdier og hvordan de skal brukes og kan hentes ut og bli brukt andre steder i spillet. Informasjon er poeng, hvilket nivå du er på, hvor langt inn i en rundt du er.

Metode og klassefordeling:
Thomas: metode 2 og 3. Klasse 1.
Kasper: metode 1 og 4. Klasse 2.
