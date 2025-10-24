import { createRouter, createWebHistory } from 'vue-router'
import Login from '../views/Login.vue'
import Dashboard from '../views/Dashboard.vue'
import Employees from '../views/Employees.vue'

const routes = [
  { path: '/', redirect: '/dashboard' },
  { path: '/login', component: Login },
  { path: '/dashboard', component: Dashboard },
  { path: '/employees', component: Employees }
]

export const router = createRouter({
  history: createWebHistory(),
  routes
})
