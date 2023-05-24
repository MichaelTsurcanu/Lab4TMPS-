# Observer #
Patternul de programare Observer este unul dintre patternurile comportamentale și este folosit pentru a realiza o comunicare eficientă între obiecte într-un sistem software. Acesta definește o relație de tip unu-la-mulți între un subiect (subject) și mai mulți observatori (observers), astfel încât atunci când starea subiectului se schimbă, toți observatorii să fie notificați și actualizați automat.

Structura:

1. Subject: este obiectul central al patternului, care menține o listă de observatori și oferă metode pentru adăugarea, eliminarea și notificarea observatorilor. Acesta poate fi o clasă sau o interfață abstractă.
2. Observer: reprezintă interfața pe care observatorii o implementează pentru a primi actualizări de la subiect. Această interfață conține, de obicei, o metodă de actualizare care este apelată de subiect atunci când are loc o modificare.
3. ConcreteSubject: este clasa concretă care implementează interfața Subject. Aceasta menține starea internă și trimite notificări observatorilor atunci când se schimbă.
ConcreteObserver: reprezintă implementarea concretă a interfeței Observer. Observatorii înregistrați în subiect vor fi de acest tip și vor primi notificări de la subiect atunci când starea acestuia se schimbă.

# Iterator #
Design pattern-ul Iterator face parte din categoria patternurilor comportamentale și este utilizat pentru a parcurge și accesa elementele unei colecții sau structuri de date fără a dezvălui detaliile de implementare ale acesteia. Acest pattern oferă o interfață unificată pentru a itera printr-o colecție și permite modificarea și extinderea modului de parcurgere a elementelor fără a afecta colecția subiacentă.

Structura:
Design pattern-ul Iterator se bazează pe următoarele elemente principale:

1. Iterator: reprezintă interfața comună utilizată pentru a itera prin elementele colecției. Această interfață definește metodele precum hasNext() pentru a verifica existența unui următor element, next() pentru a obține următorul element din colecție și, opțional, remove() pentru a șterge un element din colecție.
2. ConcreteIterator: este implementarea concretă a interfeței Iterator. Acesta conține o referință la colecția pe care o iterează și menține starea curentă a parcurgerii.
3. Colectie: reprezintă colecția sau structura de date pe care se realizează parcurgerea. Aceasta oferă o metodă getIterator() pentru a obține un iterator adecvat pentru colecție.

# Strategy #
Strategy design pattern este un model de proiectare comportamental care permite încapsularea unei familii de algoritmi interschimbabili și le permite să fie utilizate în mod interschimbabil în cadrul unui obiect. Acesta promovează ideea de "favorizează compoziția în locul moștenirii" prin definirea unui set de algoritmi ca clase separate, cunoscute sub numele de strategii, și permitând clientului să le aleagă și să le schimbe în timpul rulării.

Principalele beneficii ale utilizării acestui pattern sunt:

Încapsularea: Modelul încapsulează fiecare algoritm sau strategie în propria clasă, promovând un design curat și modular. Strategiile pot fi dezvoltate, testate și întreținute independent de codul client.

Flexibilitate: Modelul permite clientului să selecteze și să schimbe dinamic strategiile diferite în timpul rulării, fără a necesita modificări ale codului client. Acest lucru oferă o flexibilitate și adaptabilitate mai mare în gestionarea diferitelor variații ale algoritmului.

Extensibilitate: Noile strategii pot fi adăugate ușor prin implementarea interfeței de strategie, fără a modifica codul existent. Acest lucru face ușor introducerea de comportamente noi sau modificarea celor existente.

Îmbunătățirea testabilității: Modelul simplifică testarea unitară, deoarece fiecare strategie poate fi testată independent de celelalte. Această izolare facilitează asigurarea corectitudinii strategiilor individuale.

În ansamblu, Strategy design pattern promovează un design flexibil și ușor de întreținut prin separarea comportamentelor algoritmice de codul client și permiterea comutării dinamică între strategii diferite. Este deosebit de util în scenarii în care trebuie să se susțină diferite