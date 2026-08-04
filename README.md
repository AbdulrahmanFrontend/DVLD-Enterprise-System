# Driving & Vehicle Licensing Department (DVLD) System

> **Project Status:** Under Active Development 🚧  
> *Targeting initial baseline module release and end-to-end integration testing for the **People Management System**.*

---

## 📋 Executive Overview

**DVLD System** is a multi-tier desktop application designed to digitize and streamline the lifecycle of driving and vehicle licensing operations. Built with **C#**, **.NET Framework**, **WinForms**, and **SQL Server**, the architecture enforces a strict separation of concerns through a custom layered approach:

1. **Data Access Layer (DAL):** Direct ADO.NET communication, stored procedures, and parameterized queries with connection string externalization.
2. **Business Logic Layer (BLL):** Domain objects, rule evaluation, data validation, and business workflow enforcement.
3. **Presentation Layer (WinForms UI):** User management, data visualization, dynamic filtering, and modular forms.

The primary objective of this project is to practice enterprise-grade software architecture, database design integrity, and strict transaction control in a real-world relational environment.

---

## 🏛 Database & Schema Architecture

The core relational database (`DVLDSystemDb`) models the full ecosystem of driving licensing. Key schema design considerations include:

- **Strict Data Integrity:** Database-level `CHECK` constraints enforcing standardized Egyptian National ID formats (14 digits), mobile numbers, valid email patterns, and file extensions.
- **Relational Integrity:** Foreign key constraints across application types, license classes, applicant profiles, and testing records.
- **Optimized Reporting Views:** Pre-configured SQL views (e.g., `TestAppointments_View`, `LocalDrivingLicenseFullApplications_View`, `DetainedLicenses_View`) to reduce C# query logic and optimize GridView loading times.
- **Security & Authentication:** Stored procedures (`sp_Login`, `sp_IsAdminFound`) using hashed credentials (`PasswordHash`) and account status validation (`IsActive`).

---

## 🚀 Current Implementation Roadmap & Status

| Module / Feature Area | Implementation Details | Status |
| :--- | :--- | :--- |
| **Database Schema & Scripts** | Tables, Foreign Keys, Lookup Data, and SQL Views fully scripted. | ✅ Completed |
| **Core Infrastructure & DAL Setup** | Centralized `DbHelper` connection manager (`App.Config` integration). | ✅ Completed |
| **Authentication System** | Stored procedure login verification (`sp_Login`) with credential hashing. | 🟡 In Progress / Under Test |
| **People Management (First Core Milestone)** | Full CRUD for applicant/person profiles, National ID validation, photo attachments, and regional lookup filtering. | 🚧 In Active Development (Testing Phase) |
| **Application & Testing Workflows** | Business logic for Vision, Written, and Street driving tests. | ⏳ Planned Next |
| **License Issuance & Detain System** | License generation, renewal, replacement for lost/damaged, and fee collection. | ⏳ Planned Next |

---

## ⚠️ Known Technical Caveats & Work in Progress

To maintain complete engineering transparency, the following technical items are actively being refined during this pre-release development phase:

1. **Schema Constraint Fine-Tuning:**  
   The `TestAppointments` table currently enforces `AppointmentDate <= GETDATE()`. This constraint is being updated to support future scheduling (`>= GETDATE()`) as test appointment logic is finalized.
2. **Validation Layer Synchronization:**  
   C# Data Annotation / Validation attributes in the BLL are being aligned with strict SQL `CHECK` constraints (e.g., 14-digit National IDs) to capture client-side entry errors cleanly before reaching the database.
3. **Refactoring Hardcoded Queries:**  
   Transitioning remaining inline ADO.NET query execution across all modules to standardized Stored Procedures for improved security and execution plan caching.

---

## 🛠 Tech Stack & Tools

- **Language:** C# (.NET Framework)
- **UI Framework:** Windows Forms (WinForms)
- **Database Engine:** Microsoft SQL Server
- **Data Access:** ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataReader`, `DataTable`)
- **Architecture:** 3-Tier Layered Architecture (DAL / BLL / Presentation)
- **Configuration & Tools:** `App.config`, Git Version Control, SQL Server Management Studio (SSMS)

---

## 👤 Author & Maintainer

**Abdul-Rahman Nasser Abd Al-Sattar Mohamed**  
*Junior Desktop & Backend Software Developer*  
- **GitHub:** [@AbdulrahmanFrontend](https://github.com/AbdulrahmanFrontend)  
- **Focus:** C#, .NET Framework, SQL Server Architecture, & WinForms Development

---
*Note: This repository represents a live development workspace. Commits and architectural refactoring occur frequently as feature modules transition into full integration testing.*
