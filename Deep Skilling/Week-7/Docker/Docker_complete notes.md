# Docker - Complete Notes

---

# Table of Contents

1. Introduction to Docker
2. What is Docker?
3. Why Docker?
4. Virtual Machine vs Docker
5. Docker Architecture
6. Docker Components
7. Docker Installation
8. Docker Images
9. Docker Containers
10. Docker Lifecycle
11. Dockerfile
12. Docker Hub
13. Docker Volumes
14. Docker Networks
15. Docker Compose
16. Docker Commands
17. Docker Workflow
18. Advantages
19. Limitations
20. Best Practices
21. Interview Questions
22. Conclusion

---

# 1. Introduction to Docker

Docker is an open-source platform that helps developers build, package, distribute, and run applications in lightweight containers.

It ensures that applications run the same way on different systems.

---

# 2. What is Docker?

Docker is a containerization platform that packages an application along with all its dependencies, libraries, and configuration files into a single unit called a **Container**.

---

# 3. Why Docker?

Before Docker:

- Different environments caused software failures.
- Developers and testers used different configurations.
- Deployment was slow.
- Dependency management was difficult.

Docker solves these problems by providing a consistent environment.

---

# 4. Virtual Machine vs Docker

| Virtual Machine | Docker |
|-----------------|---------|
| Runs complete OS | Shares host OS |
| Heavyweight | Lightweight |
| Slow startup | Fast startup |
| Uses more memory | Uses less memory |
| Large storage | Small storage |
| Hypervisor required | Docker Engine required |

---

# 5. Docker Architecture

```text
+----------------------+
|   Docker Client      |
+----------------------+
           |
           ▼
+----------------------+
|   Docker Daemon      |
+----------------------+
      │         │
      ▼         ▼
 Images      Containers
      │
      ▼
 Docker Hub
```

---

# 6. Docker Components

## Docker Client

Used to execute Docker commands.

Example:

```bash
docker run
docker build
docker pull
```

---

## Docker Daemon

Runs in the background.

Responsibilities:

- Build images
- Create containers
- Manage images
- Manage networks
- Manage volumes

---

## Docker Engine

The core software that runs Docker.

Includes:

- Docker Daemon
- REST API
- Docker CLI

---

## Docker Registry

Stores Docker images.

Examples:

- Docker Hub
- Azure Container Registry
- Amazon ECR

---

## Docker Hub

Cloud repository for Docker images.

Features:

- Public images
- Private repositories
- Image sharing

Website:

https://hub.docker.com

---

# 7. Docker Installation

Verify installation

```bash
docker --version
```

Check Docker information

```bash
docker info
```

---

# 8. Docker Images

A Docker Image is a read-only template used to create containers.

Images contain:

- Application
- Libraries
- Dependencies
- Configuration

Examples:

```text
ubuntu
nginx
mysql
python
node
openjdk
```

Useful Commands

Download image

```bash
docker pull ubuntu
```

View images

```bash
docker images
```

Remove image

```bash
docker rmi ubuntu
```

---

# 9. Docker Containers

A container is a running instance of a Docker image.

Characteristics

- Lightweight
- Portable
- Isolated
- Fast

Commands

Create container

```bash
docker run ubuntu
```

Interactive mode

```bash
docker run -it ubuntu
```

Run in background

```bash
docker run -d nginx
```

List running containers

```bash
docker ps
```

List all containers

```bash
docker ps -a
```

Stop container

```bash
docker stop container_id
```

Start container

```bash
docker start container_id
```

Restart container

```bash
docker restart container_id
```

Remove container

```bash
docker rm container_id
```

---

# 10. Docker Container Lifecycle

```text
Image
   │
   ▼
Create
   │
   ▼
Running
   │
   ▼
Paused
   │
   ▼
Stopped
   │
   ▼
Removed
```

---

# 11. Dockerfile

A Dockerfile is a text file containing instructions to build a Docker image.

Example

```dockerfile
FROM openjdk:21

WORKDIR /app

COPY . .

RUN javac Hello.java

CMD ["java","Hello"]
```

Common Dockerfile Instructions

| Instruction | Purpose |
|-------------|----------|
| FROM | Base image |
| COPY | Copy files |
| ADD | Copy files with extra features |
| RUN | Execute command |
| CMD | Default command |
| ENTRYPOINT | Main executable |
| WORKDIR | Set working directory |
| EXPOSE | Open port |
| ENV | Environment variable |

Build image

```bash
docker build -t myapp .
```

---

# 12. Docker Hub

Push image

```bash
docker push username/myapp
```

Pull image

```bash
docker pull username/myapp
```

Login

```bash
docker login
```

Logout

```bash
docker logout
```

---

# 13. Docker Volumes

Volumes store persistent data outside containers.

Advantages

- Data persistence
- Backup
- Data sharing
- Easy recovery

Create volume

```bash
docker volume create myvolume
```

List volumes

```bash
docker volume ls
```

Remove volume

```bash
docker volume rm myvolume
```

---

# 14. Docker Networks

Networks allow containers to communicate.

Types

- Bridge Network
- Host Network
- None Network
- Overlay Network

Commands

List networks

```bash
docker network ls
```

Create network

```bash
docker network create mynetwork
```

Inspect network

```bash
docker network inspect mynetwork
```

---

# 15. Docker Compose

Docker Compose manages multiple containers using a single YAML file.

Example

```yaml
version: "3"

services:

  web:
    image: nginx

  database:
    image: mysql
```

Commands

Start services

```bash
docker compose up
```

Background mode

```bash
docker compose up -d
```

Stop services

```bash
docker compose down
```

---

# 16. Common Docker Commands

| Command | Description |
|----------|-------------|
| docker --version | Show Docker version |
| docker info | Docker information |
| docker images | List images |
| docker pull | Download image |
| docker build | Build image |
| docker run | Run container |
| docker ps | Running containers |
| docker ps -a | All containers |
| docker stop | Stop container |
| docker start | Start container |
| docker restart | Restart container |
| docker rm | Remove container |
| docker rmi | Remove image |
| docker exec -it | Enter container |
| docker logs | View logs |
| docker volume ls | List volumes |
| docker network ls | List networks |
| docker compose up | Start compose services |
| docker compose down | Stop compose services |

---

# 17. Docker Workflow

```text
Write Application
        │
        ▼
Create Dockerfile
        │
        ▼
Build Docker Image
        │
        ▼
Store Image
(Docker Hub)
        │
        ▼
Run Container
        │
        ▼
Application Running
```

---

# 18. Advantages of Docker

- Fast deployment
- Lightweight
- Portable
- Efficient resource usage
- Easy scaling
- Isolation
- Consistent environments
- Supports CI/CD
- Simplifies dependency management

---

# 19. Limitations of Docker

- Shares host operating system kernel.
- Less isolation than virtual machines.
- Security risks if containers are misconfigured.
- Persistent storage requires volumes.
- Managing many containers often requires orchestration tools like Kubernetes.

---

# 20. Docker Best Practices

- Use official base images.
- Keep images small.
- Use multi-stage builds.
- Avoid running containers as the root user.
- Store persistent data in volumes.
- Remove unused images and containers regularly.
- Keep images updated with security patches.

---

# 21. Frequently Asked Interview Questions

### What is Docker?

Docker is a platform used to build, package, and run applications inside lightweight containers.

---

### What is a Docker Image?

A Docker image is a read-only template used to create Docker containers.

---

### What is a Docker Container?

A Docker container is a running instance of a Docker image.

---

### What is Docker Hub?

Docker Hub is a cloud-based repository used to store and share Docker images.

---

### What is a Dockerfile?

A Dockerfile is a text file that contains instructions to build a Docker image.

---

### What is Docker Compose?

Docker Compose is a tool used to define and run multiple containers using a single `docker-compose.yml` file.

---

### What is the difference between Docker Image and Container?

| Docker Image | Docker Container |
|--------------|------------------|
| Read-only template | Running instance |
| Cannot execute directly | Executes the application |
| Used to create containers | Created from an image |

---

### What is a Docker Volume?

A Docker volume is used to store persistent data outside a container.

---

### What is a Docker Network?

A Docker network enables communication between containers.

---

### What command is used to view running containers?

```bash
docker ps
```

---

# 22. Complete Docker Lifecycle

```text
Write Application
        │
        ▼
Create Dockerfile
        │
        ▼
Build Image
        │
        ▼
Push Image to Docker Hub
        │
        ▼
Pull Image
        │
        ▼
Run Container
        │
        ▼
Application Executes
        │
        ▼
Store Data in Volumes
        │
        ▼
Connect Using Networks
        │
        ▼
Monitor and Manage Containers
```

---

# Conclusion

Docker is a powerful containerization platform that simplifies application development, testing, deployment, and scaling. By packaging applications with all their dependencies into containers, Docker ensures consistency across different environments, improves resource utilization, and supports modern DevOps practices such as Continuous Integration (CI) and Continuous Deployment (CD).
