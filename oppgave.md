# Gruppeoppgave: Stempelkortet

Uke 2: Objekter og innkapsling. 

## Mål

Etter oppgaven skal du kunne:
- lage en klasse som beskytter sine egne regler
- forklare hvorfor noe er `private` og noe er `public`
- finne svakheter i en klasse ved å prøve å bryte reglene utenfra

## Situasjonen

En kafé vil ha et digitalt stempelkort. Kunden får ett stempel per kaffe. Med 10 stempler kan kunden løse inn en gratis kaffe.

## Reglene klassen skal beskytte

1. Hvert kjøp gir nøyaktig ett stempel.
2. En gratis kaffe kan bare løses inn når kortet har minst 10 stempler.
3. Når en gratis kaffe løses inn, trekkes 10 stempler.
4. Antall stempler kan ikke endres direkte utenfra, og det kan aldri bli negativt.
5. Kortet må ha et eiernavn som ikke er tomt. Er navnet tomt, kaster konstruktøren en `ArgumentException`.


public ownerName {get ; private set};
private stamps {get ; private set};

## Slik jobber dere

Dere jobber når det passer for gruppa, men følg stegene.

| Steg | Hva |
|---|---|
| 1 | Analyse uten kode |
| 2 | Lag klassen |
| 3 | Bryt reglene til en annen gruppe |
| 4 | Refleksjon, hver for seg |

I steg 3 roterer teamene:

| Team | Bryter koden til |
|---|---|
| 1 | Team 3 |
| 2 | Team 1 |
| 3 | Team 2 |

Koden deles i team-kanalene på Discord (#team-1, #team-2, #team-3).

## Del 1: Analyse uten kode

Svar sammen i gruppe før dere skriver kode:
1. Hvilke verdier må kortet huske? OwnerName - Stamps and IsBlocked?
2. Hva skal man kunne *gjøre* med kortet? AddStamp() BlockCard() RedeemFreeCoffee()
3. Hvilke av reglene over handler om verdiene, og hvilke handler om handlingene? private int Stamps = 0; OwnerName <- Verdi | public AddStamp() <-handling som påvirker en verdi
4. Hvem skal kunne *lese* antall stempler? Hvem skal kunne *endre* det? Lese = alle, Endre = bare klassen AddStamp(){ if(!isBlocked) Stamps = Stamps + 1 }

## Del 2: Lag klassen

Dere skriver klassen `StampCard` fra bunnen av i filen `StampCard.cs`. `Program.cs` er der dere viser at reglene virker.

Klassen skal ha akkurat disse public-delene, slik at det andre teamet kan bruke klassen deres uten å spørre:

| Del | Hva den gjør |
|---|---|
| `public StampCard(string ownerName)` | Lager et kort med eiernavn og 0 stempler. Sjekker regel 5. |
| `public void AddStamp()` | Gir kortet ett stempel. |
| `public bool RedeemFreeCoffee()` | Returnerer `true` og trekker 10 stempler hvis kortet har minst 10. Ellers returnerer den `false` og endrer ingenting. |

Gjør dette:
1. Lag klassen `StampCard` i namespace `StampCardApp`.
2. Legg til det kortet må huske: eiernavn og antall stempler. Velg selv om det skal være fields eller properties, og om de skal være `public` eller `private`.
3. Lag konstruktøren og de to metodene i tabellen.
4. Vis i `Program.cs` at alle reglene virker. Skriv ut hva som skjer med `Console.WriteLine`.

Ikke endre navnene eller returtypene i tabellen.

Når dere er ferdige: Lim inn hele `StampCard.cs` i deres egen team-kanal, i en kodeblokk (```` ```cs ````).

## Del 3: Bryt reglene

Hent `StampCard.cs` fra team-kanalen til teamet dere skal bryte (se tabellen over). Legg den i prosjektet deres i stedet for deres egen.

Prøv å få kortet til å bryte en av reglene, **bare fra `Program.cs`**. Dere får ikke endre `StampCard.cs`.

Eksempler på ting å prøve:
- Kan dere gi kortet 100 stempler uten å kalle `AddStamp()` 100 ganger?
- Kan dere få antall stempler under 0?
- Kan dere løse inn gratis kaffe med 9 stempler?
- Kan dere lage et kort uten navn, eller endre navnet etterpå?

Skriv i team-kanalen til teamet dere brøt:
- hvilke regler dere klarte å bryte, og hvilken kodelinje som gjorde det
- hvilke regler som holdt, og hva i klassen som stoppet dere

## Del 4: Refleksjon (hver for seg)

Del 3–5 setninger i gruppechatten:
1. Hvilken regel var lettest å bryte i klassen dere fikk, og hva i koden gjorde det mulig?
2. Hva endret dere, eller hva ville dere endret, i deres egen klasse etter tilbakemeldingen?
3. Forklar med egne ord hva innkapsling er, med et eksempel fra stempelkortet.

## Ekstra

- Kortet kan sperres. Et sperret kort kan ikke få stempler og kan ikke løse inn kaffe. Hvem skal kunne sperre kortet, og hvordan hindrer dere at det låses opp igjen utenfra?
- Kafeen vil ha «dobbeltstempel-dag». Hvor i koden hører den regelen hjemme? Kan den legges til uten at regel 4 brytes?

## Hint

- Hvis noe utenfor klassen kan skrive `card.Stamps = 100;`, er regel 4 brutt.
- En property kan ha `public` get og `private` set.
  - https://www.w3schools.com/cs/cs_access_modifiers.php
  - https://www.w3schools.com/cs/cs_properties.php
- Sjekk regelen i metoden *før* dere endrer verdien.
