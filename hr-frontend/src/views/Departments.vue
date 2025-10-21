<script setup lang="ts">
import DepartmentList from '@/components/DepartmentList.vue';

</script>

<template>
    <div>
        <h2 class="text-2xl font-semibold mb-4">Departments</h2>
        <button class="bg-blue-600 text-white px-4 py-2 rounded mb-4 hover:bg-blue-700">Add Department</button>

        <DepartmentList />
    </div>
</template>

<script setup>
import DepartmentList from '@/components/DepartmentList.vue'
</script>