# Mentor Booking System (MBS)


## 0. Introduction

A platform designed to connect students with mentors, facilitating skill development, project support, and guidance through structured mentorship. The system is tailored to meet the needs of three key user roles: **Students**, **Mentors**, and **Admins**, each with specific functions to ensure a seamless mentoring experience.

- **Students**: Students can manage their project groups, assign mentors to their projects based on required skills, and view their profile and performance points. MBS allows students to search for mentors with specific expertise, book mentorship sessions, and get valuable guidance for their projects.

- **Mentors**: Mentors can showcase their skills and certifications, set and manage their schedules, and verify bookings from students. MBS also allows mentors to verify and manage group requests, providing a streamlined way to engage with students on specific project needs.

- **Admins**: Administrators oversee the system, configuring points awarded to students, managing and approving mentors, and monitoring the feedback from student-mentor interactions. This role ensures the quality and effectiveness of mentorship sessions and maintains the overall integrity of the system.

## 1. System Standout Features

- **CQRS Pattern**: Separates read and write operations, with **MongoDB** dedicated to reads and **MSSQL Server** to writes.
- **Repository Pattern**: Provides abstraction for reusable and testable data access.
- **Outbox Pattern**: Ensures reliable event handling by persisting events before processing.
- **Idempotent Pattern**: Manages duplicate events to prevent redundant actions, ensuring message consistency.

## 2. Tech Stack

### Backend: 
- ASP.NET Core 8, EF Core, MediatR, RabbitMQ, MassTransit.

### Frontend: 
- ReactJS, TypeScript, Tailwind CSS, Next.js

### Mobile: 
- Java for Android

### Deployment

- **Docker** for containerization, enabling consistent deployment across environments.
- **GitHub Workflow** and **GitHub Runner** for a streamlined CI/CD pipeline, automating the build and deployment process.
- **Nginx** for domain management and port forwarding.
- **YARP Reverse Proxy** for efficient request forwarding to specific backend services, enhancing load management.

### Database

- **MSSQL Server**: Ensures data consistency and adheres to ACID principles for transactional integrity.
- **MongoDB**: Optimized for fast read-heavy queries.
- **Redis**: Used for caching frequently accessed data and token management, improving response times.

### Architecture

- **Clean Architecture**: Modular and maintainable, facilitating easy scalability and testing.

---

This system architecture and tech stack ensure that the Mentor Booking System (MBS) is scalable, efficient, and maintains a high-quality user experience across all roles.

## 3. System Architeture
![System Architeture](https://res.cloudinary.com/dejf8mmou/image/upload/v1731514790/haxgn9u7yggjqyajrmvd.jpg)

## 4. ERD Diagram
![ERD Diagram](https://res.cloudinary.com/dejf8mmou/image/upload/v1731513592/eblg8mnf5enfoxdtzqsw.jpg)

## 5. Project Repository

- **Admin Web Repository**: [MBS-WEB_APP](https://github.com/bentran1vn/MBS-WEB_APP)
- **Mobile Repository**: [MBS-MOBILE_APP](https://github.com/bentran1vn/MBS-MOBILE_APP)
- **Command Repository**: [MBS-COMMAND](https://github.com/bentran1vn/MBS-COMMAND)
- **Query Repository**: [MBS-QUERY](https://github.com/bentran1vn/MBS-QUERY)
- **Authorization Repository**: [MBS-AUTHORIZATION](https://github.com/bentran1vn/MBS-AUTHORIZATION)
- **Reverse Proxy Repository**: [MBS-REVERSE_PROXY](https://github.com/bentran1vn/MBS-REVERSE_PROXY)
- **MBS Library Repository**: [MBS-CONTRACT](https://github.com/bentran1vn/MBS-CONTRACT)




