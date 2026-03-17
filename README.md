# 🗄️ WPF + SQLite — Aplikacja CRUD

> Prosta aplikacja desktopowa do zarządzania danymi osobowymi, zbudowana z użyciem **WPF** i **SQLite**.

---

## 📋 Opis

Aplikacja umożliwia dodawanie i przeglądanie rekordów osobowych (imię, nazwisko, PESEL) przechowywanych lokalnie w bazie danych SQLite. Dane wyświetlane są na bieżąco w tabeli po każdym dodaniu nowego rekordu.

---

## ✨ Funkcje

- ➕ Dodawanie nowych osób (Imię, Nazwisko, PESEL)
- 📊 Wyświetlanie listy wszystkich osób w tabeli
- 💾 Trwałe przechowywanie danych w lokalnym pliku SQLite (`users.db`)
- 🔒 Bezpieczne zapytania z użyciem parametrów (ochrona przed SQL Injection)

---

## 🛠️ Technologie

| Technologia | Wersja |
|---|---|
| .NET | 8.0 |
| WPF (Windows Presentation Foundation) | .NET 8 Windows |
| Microsoft.Data.Sqlite | 10.0.5 |
| C# | 12 |

---

## 📦 Wymagania

- System operacyjny: **Windows**
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) lub nowszy
- Visual Studio 2022+ (lub inne IDE obsługujące .NET 8 + WPF)

---

## 🚀 Uruchomienie

### 1. Sklonuj repozytorium

```bash
git clone https://github.com/Alxay7/WPF-SQLITE.git
cd WPF-SQLITE
```

### 2. Otwórz projekt

Otwórz plik `WPF-SQLITE.sln` w **Visual Studio**.

### 3. Uruchom aplikację

Naciśnij `F5` lub wybierz **Debug → Start Debugging**.

> Baza danych `users.db` zostanie automatycznie utworzona przy pierwszym uruchomieniu w katalogu wyjściowym aplikacji.

> ⚠️ Upewnij się, że tabela `users` istnieje w bazie. Możesz ją utworzyć manualnie za pomocą narzędzia [DB Browser for SQLite](https://sqlitebrowser.org/) lub dodać inicjalizację w kodzie.

---

## 🗂️ Struktura projektu

```
WPF-SQLITE/
├── WPF-SQLITE.sln          # Plik solucji Visual Studio
└── WPF-SQLITE/
    ├── App.xaml             # Punkt wejścia aplikacji WPF
    ├── App.xaml.cs
    ├── MainWindow.xaml      # Główny interfejs użytkownika
    ├── MainWindow.xaml.cs   # Logika aplikacji (CRUD + SQLite)
    ├── AssemblyInfo.cs
    └── WPF-SQLITE.csproj    # Plik projektu (.NET 8, WPF)
```

---

## 🖥️ Interfejs użytkownika

Okno aplikacji podzielone jest na dwie sekcje:

| Sekcja | Opis |
|---|---|
| **Panel lewej** | Formularz do wpisania Imienia, Nazwiska i PESEL-u oraz przycisk „Dodaj" |
| **Panel prawy** | Tabela (DataGrid) wyświetlająca wszystkie zapisane osoby |

---

## 📐 Schemat bazy danych

Aplikacja używa jednej tabeli `users`:

```sql
CREATE TABLE users (
    Id      INTEGER PRIMARY KEY AUTOINCREMENT,
    Imie    TEXT NOT NULL,
    Nazwisko TEXT NOT NULL,
    Pesel   TEXT NOT NULL
);
```

---

## 📄 Licencja

Ten projekt jest udostępniony na zasadach open-source. Możesz go swobodnie używać i modyfikować.
