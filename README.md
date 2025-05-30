# 📚 SimpleBookCatalog

![.NET 8](https://img.shields.io/badge/.NET-8.0-blue)
![Platform](https://img.shields.io/badge/platform-Blazor_Server-orange)
![License](https://img.shields.io/github/license/azizp2/SimpleBookCatalog)

SimpleBookCatalog adalah aplikasi katalog buku berbasis **Blazor Server**, dibangun menggunakan pendekatan **Clean Architecture**. Proyek ini dirancang untuk menjadi contoh praktis membangun aplikasi Blazor dengan pemisahan tanggung jawab yang jelas antar lapisan.

---

## ✨ Fitur Utama

- ✅ Tambah, Edit, Hapus, dan Lihat data buku
- ✅ Notifikasi interaktif menggunakan **SweetAlert2**
- ✅ Interop JavaScript untuk konfirmasi hapus
- ✅ Dependency Injection terstruktur
- ✅ Arsitektur modular dan scalable (Clean Architecture)
- ✅ Validasi dasar dan UI sederhana
- 🚧 Fitur-fitur lanjutan seperti Pagination, Filter, dan Auth akan ditambahkan

---

## 🧱 Struktur Proyek (Clean Architecture)

SimpleBookCatalog/
├── SimpleBookCatalog/ # Layer UI (Blazor Server)
│ ├── wwwroot/ # Static files (JS, CSS, images)
│ ├── Pages/ # Razor pages & komponen UI
│ ├── Shared/ # Komponen Blazor yang dipakai bersama
│ ├── Program.cs # Konfigurasi aplikasi dan service DI
│ └── _Imports.razor # Direktif umum Razor
│
├── SimpleBookCatalog.Application/ # Layer business logic / use cases
│ ├── Services/ # Implementasi use case, service logic
│ ├── Interfaces/ # Interface service dan repository
│ ├── DTOs/ # Data Transfer Objects
│ └── Validators/ # Validasi input (opsional)
│
├── SimpleBookCatalog.Domain/ # Layer domain
│ ├── Entities/ # Entity model, misal Book.cs
│ ├── Enums/ # Enum yang digunakan domain
│ ├── Exceptions/ # Custom exception domain
│ └── Interfaces/ # Interface domain service dan repository
│
├── SimpleBookCatalog.Infrastructure/ # Layer implementasi data & service eksternal
│ ├── Data/ # DbContext, migrasi Entity Framework Core
│ ├── Repositories/ # Implementasi repository
│ ├── Services/ # Service eksternal (email, logging, dll)
│ └── Migrations/ # Folder migrasi EF Core
│
├── .gitignore # File ignore git
├── README.md # Dokumentasi proyek
├── SimpleBookCatalog.sln # Solution file
└── LICENSE # Lisensi proyek

## 📌 Catatan Tambahan

Kalau ingin saya bantu tambahkan badge build, dokumentasi deployment, atau panduan lain, beri tahu saja!
