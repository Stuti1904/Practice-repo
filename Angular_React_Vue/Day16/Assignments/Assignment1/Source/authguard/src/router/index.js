import { createRouter, createWebHistory } from 'vue-router'
const routes = [
  {
    path: '/user',
    name: 'userView',
    component: () => import('../views/UserView.vue'),
    beforeEnter: (to, from, next) => {
      if (localStorage.getItem('user')) {
        next();
      } else {
        next({
          name: 'userView',
        });
      }
    },
  },
  {
    path: '/admin',
    name: 'adminView',
    component: () => import('../views/AdminView.vue'),
    beforeEnter: (to, from, next) => {
      if (localStorage.getItem('admin')) {
        next();
      } else {
        next({
          name: 'adminView',
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
