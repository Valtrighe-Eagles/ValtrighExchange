**ValtrighExchange**

# Funzionamento
ValtrighExchange è un applicativo che permette di simulare il funzionamento di una borsa valori grazie a dei thread, che comprando o vendendo le azioni influenzano la valutazione della criptovaluta.
Sebbene sarebbe stato interessante simulare in modo più realistico possibile le fluttuazioni di valore, è pressochè impossibile replicare gli eventi esterni anche più rilevanti all'interno del programma, quindi queste si baseranno solo e soltanto sugli scambi.

## Criptovaluta
La criptovaluta è generata tramite un applicativo in python a cui successivamente i thread faranno richiesta, questo viene aggiornato ogni 1 minuto e genera un grafico sull'andamento. Al programma che farà richiesta verrà restituito l'ultimo grafico generato e le informazioni relative alla criptovaluta

## Borsa
Appena entrato nel sistema della borsa puoi fare l'accesso al tuo profilo con le credenziali che ti vengono fornite al momento della registrazione.
Questa scelta ti consentirà di accedere ad una serie di funzioni a te dedicate

### Cliente
Il cliente viene registrato con le seguenti informazioni:
1. ID (string) generato automaticamente dal programma
2. Nome e Cognome (string) vengono inseriti dall'utente al momento della registrazione
3. Numero di telefono (string)
4. Email (string)

3. Saldo (? int ?) in Criptovaluta
4. Saldo (? int ?) in Euro



classe per inserire e prelevare i soldi

https://medium.com/the-capital/creating-simple-cryptocurrency-using-c-and-net-part-4-block-header-c8ad97fd237b
https://putukusuma.medium.com/developing-simple-crypto-application-using-c-48258c2d4e45

public class Transaction
{
    public long TimeStamp {set; get;}
    public string Sender {set; get;}
    public string Recipient {set; get;}
    public double Amount {set; get;}
    public double Fee {set; get;}
}

public class Block
{
    public int Height { get; set; }
    public Int64 TimeStamp { get; set; }
    public byte[] PrevHash { get; set; }
    public byte[] Hash { get; set; }
    public Transaction[] Transactions { get; set; }
    public string Creator { get; set; }
}
