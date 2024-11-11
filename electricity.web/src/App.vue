<template>
  <div id="app">
    <div></div>
    <h1>Графік відключення світла</h1>
    <div class="header">
      
      <div class="controls">
        <select v-model="selectedCity" @change="fetchZones">
          <option disabled value="">Виберіть місто</option>
          <option v-for="city in cities" :key="city.id" :value="city.id">{{ city.name }}</option>
        </select>

        <select v-model="selectedZone" :disabled="!zones.length">
          <option disabled value="">Виберіть зону</option>
          <option v-for="zone in zones" :key="zone.id" :value="zone.id">{{ zone.zoneKey }}</option>
        </select>

        <button @click="fetchSchedule">Отримати дані</button>

        <button @click="toggleEditMode" :class="{ 'active': isEditMode }">
          {{ isEditMode ? 'Заблокувати зміни' : 'Розблокувати зміни' }}
        </button>

        <button @click="downloadAsJson">Завантажити JSON</button>
      </div>
    </div>

    <ScheduleTable :scheduleData="scheduleData" :isEditMode="isEditMode" @updateStatus="updateStatus" />
  </div>
</template>

<script lang="ts">
  import { defineComponent } from 'vue';
  import ScheduleTable from './components/ScheduleTable.vue';

  export default defineComponent({
    name: 'App',
    components: {
      ScheduleTable,
    },
    data() {
      return {
        cities: [] as Array<{ id: number; name: string }>,
        zones: [] as Array<{ id: number; cityId: number, zoneKey: number}>,
        selectedCity: '' as number,
        selectedZone: '' as number,
        scheduleData: [] as Array<any>,
        isEditMode: false,
      };
    },
    async created() {
      await this.fetchCities();
    },
    methods: {
      async fetchCities() {
        try {
          const response = await fetch('/Electricity/cities');
          if (!response.ok) {
            throw new Error("Failed to fetch cities");
          }
          const data = await response.json();
          this.cities = data;
        } catch (error) {
          console.error("Error fetching cities:", error);
        }
      },
      async fetchZones() {
        this.selectedZone = '';
        this.zones = [];

        if (!this.selectedCity) return;

        try {
          const response = await fetch(`/Electricity/zones/${this.selectedCity}`);
          if (!response.ok) {
            throw new Error("Failed to fetch groups");
          }
          const data = await response.json();
          this.zones = data;
        } catch (error) {
          console.error("Error fetching groups:", error);
        }
      },
      async fetchSchedule() {
        if (!this.selectedCity || !this.selectedZone) {
          alert("Будь ласка, виберіть місто та зону.");
          return;
        }

        try {
          const response = await fetch(`/Electricity/spreadsheet?cityId=${this.selectedCity}&zoneKey=${this.selectedZone}`);
          if (!response.ok) {
            alert("Дані відсутні");
            throw new Error("Failed to fetch schedule data");
          }
          const data = await response.json();
          this.scheduleData = data;
        } catch (error) {
          console.error("Error fetching schedule:", error);
        }
      },

      toggleEditMode() {
        this.isEditMode = !this.isEditMode;
      },

      async updateStatus(day, hour, newStatus) {
        try {
          const response = await fetch('/Electricity/updateStatus', {
            method: 'PATCH',
            headers: {
              'Content-Type': 'application/json',
            },
            body: JSON.stringify({
              spreadsheetId: day.id,
              hour,
              status: newStatus,
            }),
          });
          if (!response.ok) {
            throw new Error("Failed to update status");
          }
          console.log("Status updated successfully");
        } catch (error) {
          console.error("Error updating status:", error);
        }
      },
      downloadAsJson() {
        const jsonData = JSON.stringify(this.scheduleData, null, 2); 
        const blob = new Blob([jsonData], { type: 'application/json' });
        const url = URL.createObjectURL(blob);

        const link = document.createElement('a');
        link.href = url;
        link.download = 'scheduleData.json';
        link.click();

        URL.revokeObjectURL(url);
      },
    },
  });
</script>

<style>
  #app {
    font-family: Arial, sans-serif;
    text-align: center;
    max-width: 90%;
    height: 800px;
    width: 1800px;
    margin: 0 auto;
    padding-top: 20px;
  }

  h1{
      height: 10%;
  }

  .header {
    display: flex;
    flex-direction: column;
    align-items: center;
    margin-bottom: 20px;
  }

  .controls {
    display: flex;
    gap: 10px;
    margin-top: 10px;
    flex-wrap: wrap;
    justify-content: center;
  }

  .table-container {
    margin-top: 20px;
    display: flex;
    justify-content: center;
  }
  select{
    width: 150px;
  }

  button, select {
    padding: 8px 12px;
    font-size: 1em;
    border: 1px solid #ccc;
    border-radius: 4px;
  }

  button {
    width: 130px;
    background-color: #4CAF50;
    color: white;
    cursor: pointer;
    transition: background-color 0.3s ease;
  }

  button.active {
    background-color: #ff6347;
    color: white;
  }

  button:hover {
    background-color: #45a049;
  }

  table {
    height: 1000px;
    border-collapse: collapse;
    margin-top: 10px;
  }
</style>
