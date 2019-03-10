# JavaToDotNet
## Temat: Translator z Javy do C#
Przygotowali: Mateusz Bargiel, Damian Tabański

1. Specyfikacja gramatyki języka
2. Opis systemu typizacji dla tłumaczonego języka
3. Uzasadnienie wyboru konkretnego generatora parserów
4. Opis napotkanych problemów, sposób ich rozwiązania
5. Bibliografia i linkografia


## Specyfikacja Gramatyki Języka

GitHub: https://github.com/antlr/grammars-v4/blob/master/java9/Java9.g4

## Opis systemu typizacji dla tłumaczonego języka

Celem naszej aplikacji jest poprawne tłumaczenie języka Java (wersja 9) na C#a (wersja 7.0)

Oba języki są językami o podobnej budowie. Są to języki wielo-paradygmatowe, obiektowe i statycznie typowane.

System typizacji tłumaczonego języka jest więc statyczny. Oznacza to, że sprawdzanie typów odbywa się podczas kompilacji, w przeciwieństwie do języków dynamicznie typowanych, gdzie sprawdzanie odbywa się podczas działania programu (runtime).

## Uzasadnienie wyboru konkretnego generatora parserów

Do wykonania tego zadania zdecydowaliśmy się skorzystać z generatora parserów o nazwie ANTLR. Wynika to z faktu, że jest to narzędzie wspierane przez zarówno platformę Javy jak i .NETu. Co więcej istnieją już niezwykle dopracowane gramatyki dla wielu języków, z których łatwo można skorzystać. Składnia ANTLR jest prosta, czytelna i logiczna co ułatwia zadanie.

## Opis napotkanych problemów, sposób ich rozwiązania.

  a) modyfikator klasy/metody transient

W tym przypadku problem można było rozwiązać poprzez adnotacje [ScriptIgnore] nad metodą lub klasą. Wymagało to odwołania się do childa ( identyfikatora klasy / metody ) w jego parencie ( deklaracji klasy / metody ) i  na tej podstawie wstawianie adnotacji.

  b) modyfikator klasy / metody strictfp

strictfp nie jest w żaden sposób wspierany w C#. (zobacz rozwiązanie dla niewspieranych słów kluczowych )

nie wspierane w C# ( zobacz rozwiązanie dla niewspieranych słów kluczowych )

  c) Niejasne sformułowania gramatyk, które w wygenerowanym parserze nie działały w odpowiedni sposób. przykład:

  d) Niewspierane słowa kluczowe

W takich przypadkach parser rzuca wyjątek NotSupportedException

dims
  :  annotation* '[' ']' (annotation* '[' ']')*
  ;

W tym przypadku nasz Visitor otrzymał listę adnotacji i nic po za tym. To zbyt mało informacji aby poprawnie przetłumaczyć sformułowanie. Aby rozwiązać ten problem należałoby skorzystać bezpośrednio z tokenów co jest skomplikowanym i czasochłonnym rozwiązaniem.

## Bibliografia i Linkografia

Gramatyki ANTLR: https://github.com/antlr/grammars-v4
ANTLR: http://www.antlr.org/
ANTLR Tutorial: https://tomassetti.me/antlr-mega-tutorial/



    
