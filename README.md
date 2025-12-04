# SafeShip - Feature Rollout & Telemetry Service for Desktop Clients

## What SafeShip Does

- SafeShip.API provides endpoints to register a client application, get feature flags and rollout settings, and send telemetry events.
- SafeShip.Client an startup registers with the API, fetches config with feature flags, logs which features are enabled, and sends telemetry events.
- SafeShip.Store stores in-memory clients, configs, and telemetry events.
- SafeShip.Dashboard (TBD)

## Stack

- .NET 8
- C#

## Current Status: MVP in progress
