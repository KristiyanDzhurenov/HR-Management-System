import { defineStore } from 'pinia'
import axios from 'axios'

export const useUserStore = defineStore('user', {
  state: () => ({
    user: null,
    token: null
  }),
  actions: {
    async login(email, password) {
      const res = await axios.post('http://localhost:5000/api/auth/login', { email, password })
      this.user = res.data.user
      this.token = res.data.token
      axios.defaults.headers.common['Authorization'] = `Bearer ${this.token}`
    },
    logout() {
      this.user = null
      this.token = null
      delete axios.defaults.headers.common['Authorization']
    }
  }
})
