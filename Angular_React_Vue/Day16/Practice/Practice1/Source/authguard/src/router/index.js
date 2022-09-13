import { createRouter, createWebHistory } from 'vue-router';
import HomeView from '../views/HomeView.vue';

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView,
  },
  {
    path: '/about',
    name: 'about',
    component: () => import('../views/AboutView.vue'),
  },
  {
    path: '/protected',
    name: 'protected',
    component: () => import('../views/ProtectedView.vue'),
    beforeEnter: (to, from, next) => {
      if (localStorage.length!=0) {
        next();
      } else {
        next({
          name: 'home',
        });
      }
    },
  },
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
});

export default router;
