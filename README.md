# DotnetPlayground

A simple ASP.NET Core 8 Razor Pages site, ready for DevOps experimentation.

## Run locally

```bash
cd src/DotnetPlayground
dotnet run
```

App at http://localhost:5080

## Docker

```bash
docker build -t dotnet-playground:local .
docker run --rm -p 8080:8080 dotnet-playground:local
```

Open http://localhost:8080

## Tests

```bash
dotnet test
```

## CI

`.github/workflows/ci.yml` builds, tests, and pushes a Docker image to GHCR on push to `main`.

## Kubernetes

```bash
kubectl apply -f k8s/
```

Manifests: `Deployment`, `Service`, `Ingress`. Edit the image to point at your registry.

## DevOps ideas to play with

- Add a SQL Server / Postgres sidecar with docker-compose
- Wire up Helm or Kustomize overlays for dev/stage/prod
- Add OpenTelemetry exporter to a local Jaeger
- Add a healthcheck-driven HPA in Kubernetes
- Try a blue/green or canary rollout with Argo Rollouts
