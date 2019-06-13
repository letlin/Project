import Vue from 'vue'
import Router from 'vue-router'
import Home_comp from "./views/Home.vue"
import FindDocument_comp from "./views/FindDocument.vue"
import NotFound_comp from "./components/NotFound.vue"
import TimGiayTo_comp from "./views/TimGiayTo.vue"

Vue.use(Router)

const router = new Router({
  mode: 'history',
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home_comp
    },
    {
      path: '/tim-chinh-chu',
      name: 'FindDocument',
      component: FindDocument_comp
    },
    {
      path: '/tim-kiem-giay-to',
      name: 'TimGiayTo',
      component: TimGiayTo_comp
    },
  
   
    { path: "*", component: NotFound_comp }
  ]
})
router.beforeEach((to, from, next) => {
  if (!to.matched.length) {
    next('/notFound');
  } else {
    next();
  }
});
export default router;
