Opis projektu:

Projekt przedstawia prostą aplikację konsolową do zarządzania wypożyczalnią sprzętu na uczelni.
Umożliwia dodawanie sprzętu i użytkowników, wypożyczanie sprzętu, zwroty oraz generowanie raportu.
System obsługuje różne typy sprzętu (np. laptop, kamera, projektor) oraz różne typy użytkowników (student, pracownik), którzy mają różne limity wypożyczeń.

Struktura projektu:

Projekt podzieliłem na kilka głównych części:

Models – klasy domenowe (Equipment, Rent, User itd.)
Services – logika biznesowa (RentService, EquipmentService  itd.)
Enums / Exceptions – pomocnicze rzeczy typu statusy i wyjątki
Program.cs – tylko scenariusz pokazowy

Kohezja:
Klasy są spójne – np. wszystko co dotyczy jednego wypożyczenia jest w klasie Rent, a nie rozrzucone po całym projekcie.

Coupling:
Program korzysta z interfejsów (IRentService, IEquipmentService)
implementacja może się zmienić bez zmiany reszty kodu

Zastosowałem dziedziczenie i interfesjy tam gdzie faktcznie miały sens
Starałem się, żeby każda klasa miała jedną odpowiedzialność
