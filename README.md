🎟️ TDD Ticket Booking
Ett testdrivet utvecklingsprojekt (TDD) där bokningslogik implementeras steg‑för‑steg genom enhetstester och tydliga krav.

📌 Projektöversikt
Detta projekt demonstrerar hur man bygger en bokningsfunktion med testdriven utveckling (TDD) i C#. Fokus ligger på att skriva tester som verifierar och validerar funktionaliteten innan själva implementationen skapas.

Projektet visar även förmåga att arbeta med:

Avancerade klasser, objekt och metoder

Starka och tydliga datatyper

Kodstruktur och syntax som följer best practices och projektstandard

Separering av ansvar (SoC) och ren arkitektur i liten skala

🧪 Testdriven utveckling (TDD)
Arbetssättet följer TDD‑cykeln:

Red – Skriv ett test som misslyckas

Green – Implementera minsta möjliga kod för att få testet att passera

Refactor – Förbättra kod och struktur utan att ändra beteendet

Alla centrala delar av bokningsflödet testas i TicketBookingRequestProcessorTests.cs.

🏗️ Arkitektur & Struktur
Projektet består av följande huvudkomponenter:

Fil	Beskrivning
TicketBookingRequest.cs	Representerar inkommande bokningsdata
TicketBookingResponse.cs	Returnerar resultatet av en bokningsförfrågan
ITicketBookingRepository.cs	Abstraktion för datalagring
TicketBookingRequestProcessor.cs	Kärnlogiken som hanterar bokningsprocessen
TicketBooking.cs	Domänmodell för en bokning
TicketBookingRequestProcessorTests.cs	Enhetstester som styr utvecklingen

🎯 Funktionalitet
Projektet hanterar bland annat:

Validering av bokningsförfrågningar

Skapande av bokningar via repository‑lager

Generering av svar med status och boknings‑ID

Hantering av edge cases genom tester

🛠️ Tekniker & Verktyg
C# / .NET

xUnit för enhetstester

TDD‑metodik

Objektorienterad programmering

Ren och standardiserad kodstruktur

🚀 Syfte
Projektet är utvecklat som en del av utbildningen i testdriven utveckling och avancerad objektorienterad programmering, med målet att:

Förstå och tillämpa TDD i praktiken

Skriva robust, testbar och underhållbar kod

Arbeta enligt etablerade kodstandarder

Träna på att bygga små, tydliga och välstrukturerade system
