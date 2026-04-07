# 🎟️ TDD Ticket Booking

Ett kort projekt som demonstrerar **testdriven utveckling (TDD)** i C#. Funktionaliteten byggs steg för steg genom att först skriva tester och sedan implementera minsta möjliga kod för att få dem att passera.

## 🔍 Syfte
- Skriva tester som verifierar och validerar logik innan implementation.
- Arbeta med avancerade **klasser, objekt, metoder och datatyper**.
- Följa en tydlig och standardiserad **kodstruktur**.

## 🧪 TDD‑flöde
1. **Red** – skriv ett test som misslyckas  
2. **Green** – implementera kod som får testet att passera  
3. **Refactor** – förbättra struktur utan att ändra beteende  

## 🏗️ Struktur
- `TicketBookingRequest` – inkommande bokningsdata  
- `TicketBookingResponse` – resultat av bokning  
- `TicketBooking` – domänmodell  
- `ITicketBookingRepository` – abstraktion för datalagring  
- `TicketBookingRequestProcessor` – kärnlogik  
- `TicketBookingRequestProcessorTests` – enhetstester som styr utvecklingen  

## 🛠️ Tekniker
- C# / .NET  
- xUnit  
- Objektorienterad programmering  
- Testdriven utveckling  

## 🚀 Kort sammanfattning
Projektet visar hur TDD kan användas för att skapa robust och testbar logik i ett bokningssystem, med fokus på ren kod och tydliga strukturer.
