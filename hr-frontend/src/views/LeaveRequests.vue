<template>
    <div>   
        <h2 class="text-2xl font-semibold mb-4">Leave Requests</h2>
        <button class="bg-yellow-500 text-white px-4 py-2 rounded mb-4 hover:bg-yellow-700">New Request</button>
        <LeaveRequestList />
        <ul>
            <li v-for="request in leaveRequests" :key="request.id">
                {{ request.employeeName }} - {{ request.startDate }} to {{ request.endDate }} ({{ request.status }})
            </li>
        </ul>
    </div>
</template>

<script setup lang>
import LeaveRequestList from '@/components/LeaveRequestList.vue';
</script>