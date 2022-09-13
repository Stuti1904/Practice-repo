import { createRouter, createWebHistory } from 'vue-router';
import StudentDetails from '../views/StudentDetails.vue';

const routes = [
  {
    path: '/',
    name: 'StudentDetails',
    component: StudentDetails,
    children: [
      {
        path: '/FeesView/:id',
        name: 'FeesView',
        component: () => import('../views/FeesView.vue'),
      },
      {
        path: '/ResultView/:id',
        name: 'ResultView',
        component: () => import('../views/ResultView.vue'),
      },
    ],
  },
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
});

export default router;
