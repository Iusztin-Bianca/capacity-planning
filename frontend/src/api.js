import { API_BASE_URL } from './config';

const del = (url) => fetch(url, { method: 'DELETE' });

export const teamsApi = {
  getAll: () => fetch(`${API_BASE_URL}/teams`).then(r => r.json()),
  create: (data) => fetch(`${API_BASE_URL}/teams`, {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(data)
  }).then(r => r.json()),
  delete: (id) => del(`${API_BASE_URL}/teams/${id}`),
};

export const initiativesApi = {
  getAll: () => fetch(`${API_BASE_URL}/initiatives`).then(r => r.json()),
  create: (data) => fetch(`${API_BASE_URL}/initiatives`, {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(data)
  }).then(r => r.json()),
  delete: (id) => del(`${API_BASE_URL}/initiatives/${id}`),
};

export const epicsApi = {
  getAll: () => fetch(`${API_BASE_URL}/epics`).then(r => r.json()),
  create: (data) => fetch(`${API_BASE_URL}/epics`, {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(data)
  }).then(r => r.json()),
  delete: (id) => del(`${API_BASE_URL}/epics/${id}`),
};

export const capacityApi = {
  getReport: (startDate, endDate) =>
    fetch(`${API_BASE_URL}/capacity?startDate=${startDate}&endDate=${endDate}`).then(r => r.json()),
};

export const personsApi = {
  getByTeam: (teamId) => fetch(`${API_BASE_URL}/persons/by-team/${teamId}`).then(r => r.json()),
  create: (data) => fetch(`${API_BASE_URL}/persons`, {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(data)
  }).then(r => r.json()),
  delete: (id) => del(`${API_BASE_URL}/persons/${id}`),
};
