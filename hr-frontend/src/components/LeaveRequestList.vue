<script setup lang="ts">
import { ref, onMounted } from 'vue'
import axios from 'axios'

interface LeaveRequest {
  id: number
  employeeName: string
  startDate: string
  endDate: string
  status: string
}

const leaveRequests = ref()

onMounted(async () => {
  try {
    const response = await axios.get('http://localhost:5291/api/leaverequests')
    leaveRequests.value = response.data
  } catch (error) {
    console.error('Error fetching leave requests:', error)
  }
})
</script>

<template>
  <div>
    <h3 class="text-xl font-semibold mb-2">Leave Requests</h3>
    <ul class="bg-white shadow rounded-xl divide-y">
      <li
        v-for="request in leaveRequests"
        :key="request.id"
        class="p-3 hover:bg-gray-50 flex justify-between"
      >
        <div>
          <span class="font-medium">{{ request.employeeName }}</span>
          <p class="text-sm text-gray-500">
            {{ request.startDate }} to {{ request.endDate }}
          </p>
        </div>

        <span
          :class="{
            'text-yellow-600': request.status === 'Pending',
            'text-green-600': request.status === 'Approved',
            'text-red-600': request.status === 'Rejected'
          }"
        >
          {{ request.status }}
        </span>
      </li>
    </ul>
  </div>
</template>
