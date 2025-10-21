<template>
  <div class="employees">
    <h2 class="text-2xl font-semibold mb-4">Employees</h2>
    <button class="bg-blue-600 text-white px-4 py-2 rounded mb-4 hover:bg-green-700">Add Employee</button>

    <EmployeeList />
    <ul>
      <li v-for="employee in employees" :key="employee.id">
        {{ employee.name }} - {{ employee.position }}
      </li>
    </ul>
    <EmployeeCard name="Alice" position="HR Manager" class=""/>
    <EmployeeCard name="Bob" position="Backend Developer" />
            <EmployeeCard
            name="Kristiyan Ivanov"
            position="Frontend Developer"
            department="Engineering"
            avatar="https://randomuser.me/api/portraits/men/32.jpg"
            />
  </div>
  </template>
  <script setup lang="ts">
defineProps<{
  employees: [{
    id: number;
    name: string;
    position: string;
  }];
}>()

import EmployeeCard from '@/components/EmployeeCard.vue'
import EmployeeList from '@/components/EmployeeList.vue';
</script>