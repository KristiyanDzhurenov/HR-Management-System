<template>
  <div class="employees">
    <h1>Employees</h1>
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
</script>