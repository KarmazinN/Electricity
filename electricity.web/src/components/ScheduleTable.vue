<template>
  <table>
    <thead>
      <tr>
        <th>День</th>
        <th v-for="hour in hours" :key="hour">{{ hour.replace('hour', '') + ':00' }}</th>
      </tr>
    </thead>
    <tbody>
      <tr v-for="(day, index) in scheduleData" :key="index">
        <td>{{ day.dateName }}</td>
        <td v-for="hour in hours"
            :key="hour"
            @click="toggleStatus(day, hour)"
            :class="{ 'on': day[hour], 'off': !day[hour], 'disabled': !isEditMode }">
          ●
        </td>
      </tr>
    </tbody>
  </table>
</template>

<script lang="ts">
  import { defineComponent, PropType } from 'vue';

  export default defineComponent({
    name: 'ScheduleTable',
    props: {
      scheduleData: {
        type: Array as PropType<Array<any>>,
        required: true,
      },
      isEditMode: {
        type: Boolean,
        required: true,
      },
    },
    emits: ['updateStatus'],
    computed: {
      hours() {
        return [
          'hour00', 'hour01', 'hour02', 'hour03', 'hour04', 'hour05', 'hour06', 'hour07',
          'hour08', 'hour09', 'hour10', 'hour11', 'hour12', 'hour13', 'hour14', 'hour15',
          'hour16', 'hour17', 'hour18', 'hour19', 'hour20', 'hour21', 'hour22', 'hour23'
        ];
      }
    },
    methods: {
      toggleStatus(day, hour) {
        if (!this.isEditMode) return;

        day[hour] = !day[hour];

        this.$emit('updateStatus', day, hour, day[hour]);
      }
    },
  });
</script>

<style scoped>
  table {
    height: 900px;
    border-collapse: collapse;
    margin-top: 10px;
  }

  th, td {
    padding: 10px;
    border: 1px solid #ddd;
    text-align: center;
  }

  th {
    background-color: #f2f2f2;
    font-weight: bold;
  }

  .on, .off {
    font-size: 48px;
  }

  .on {
    color: green;
  }

  .off {
    color: red;
  }

  .disabled {
    cursor: not-allowed;
    opacity: 0.70;
  }

</style>
