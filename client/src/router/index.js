import Vue from 'vue'
import Router from 'vue-router'
import christmasParadeCountdown from '@/components/christmasParadeCountdown'
import tracker from '@/components/tracker'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'christmasParadeCountdown',
      component: christmasParadeCountdown
    },
    {
      path: '/tracker',
      name: 'tracker',
      component: tracker
    }
  ]
})
